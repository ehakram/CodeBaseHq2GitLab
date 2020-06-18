using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using ToolBuddy.CodeBase2GitLab.CodeBase;

namespace ToolBuddy.CodeBase2GitLab.GitLab
{
    /// <remarks>GitLab Api documentation https://docs.gitlab.com/ce/api/README.html </remarks>
    static public class GitLabMethods
    {

        static public async void UploadGitLabTickets(HttpClient httpClient, Ticket[] tickets, string gitLabAccessToken, string projectName, string userName)
        {
            string targetGitlabTicketsUri = string.Format("https://gitlab.com/api/v4/projects/{0}%2F{1}/issues", userName, projectName);

            foreach (Ticket ticket in tickets)
            {
                //Create ticket
                HttpRequestMessage request = new HttpRequestMessage { RequestUri = new Uri(targetGitlabTicketsUri), Method = HttpMethod.Post };
                request.Headers.Add("Private-Token", gitLabAccessToken);

                FormUrlEncodedContent content;
                {
                    Dictionary<string, string> postParams = new Dictionary<string, string>();
                    postParams["title"] = ticket.summary;
                    bool hasAttachement = ticket.ticketnotes?.ticketnote != null && Array.Exists(ticket.ticketnotes.ticketnote, n => n.attachments?.attachment != null && n.attachments.attachment.Any());
                    postParams["labels"] = $"{ticket.type.name},{ticket.category.name},CodeBase{(hasAttachement ? ",Attachement" : string.Empty)}";
                    postParams["weight"] = PriorityToWeight(ticket.priority).ToString();
                    postParams["created_at"] = ToISO8601Date(ticket.createdat.Value);
                    postParams["updated_at"] = ToISO8601Date(ticket.updatedat.Value);
                    content = new FormUrlEncodedContent(postParams);
                }
                request.Content = content;

                HttpResponseMessage result = await httpClient.SendAsync(request);
                Contract.Assert(result.IsSuccessStatusCode);

                //get the ticket iid
                dynamic jsonAnswer = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result);
                string issueId = jsonAnswer.iid;


                //Close ticket if needed
                CodeBaseStatus status = (CodeBaseStatus)ticket.status.order.Value;
                Contract.Assert(status != CodeBaseStatus.Unknown);
                bool isClosed = status == CodeBaseStatus.Completed || status == CodeBaseStatus.Invalid;
                if (isClosed)
                {
                    HttpRequestMessage requestMessage = new HttpRequestMessage { RequestUri = new Uri($"{targetGitlabTicketsUri}/{issueId}"), Method = HttpMethod.Put };
                    requestMessage.Headers.Add("Private-Token", gitLabAccessToken);

                    FormUrlEncodedContent encodedContent;
                    {
                        Dictionary<string, string> postParams = new Dictionary<string, string>();
                        postParams["state_event"] = "close";
                        encodedContent = new FormUrlEncodedContent(postParams);
                    }
                    requestMessage.Content = encodedContent;

                    await httpClient.SendAsync(requestMessage).ContinueWith(x => Contract.Assert(x.Result.IsSuccessStatusCode));
                    Console.WriteLine("closed " + ticket.ticketid.Value);
                }

                //Comments
                List<Tuple<String, DateTime>> comments = new List<Tuple<string, DateTime>>();

                //////original id
                comments.Add(new Tuple<string, DateTime>($"Original CodeBase ticket id {ticket.ticketid.Value}", DateTime.UtcNow));

                //////special status
                switch (status)
                {
                    case CodeBaseStatus.Invalid:
                        comments.Add(new Tuple<string, DateTime>("Imported as Invalid", DateTime.UtcNow));
                        break;
                    case CodeBaseStatus.Delayed:
                        comments.Add(new Tuple<string, DateTime>("Imported as Delayed", DateTime.UtcNow));
                        break;
                    case CodeBaseStatus.InProgress:
                        comments.Add(new Tuple<string, DateTime>("Imported as In progress", DateTime.UtcNow));
                        break;
                    case CodeBaseStatus.Accepted:
                        comments.Add(new Tuple<string, DateTime>("Imported as Accepted", DateTime.UtcNow));
                        break;
                }

                //////attachments
                if (ticket.ticketnotes?.ticketnote != null)
                {
                    foreach (Ticketnote ticketnote in ticket.ticketnotes.ticketnote)
                    {
                        if (string.IsNullOrEmpty(ticketnote.content) == false)
                            comments.Add(new Tuple<string, DateTime>(ticketnote.content, ticketnote.createdat.Value));
                        if (ticketnote.attachments?.attachment != null)
                        {
                            foreach (Attachment attachment in ticketnote.attachments.attachment)
                                comments.Add(new Tuple<string, DateTime>($"Attachment\nName: {attachment.filename}\nURL: {attachment.url}\nType: {attachment.contenttype}\nSize: {attachment.filesize.Value}", ticketnote.createdat.Value));
                        }
                    }
                }

                //////send the comments
                foreach (Tuple<string, DateTime> comment in comments)
                {
                    HttpRequestMessage requestMessage = new HttpRequestMessage { RequestUri = new Uri($"{targetGitlabTicketsUri}/{issueId}/notes"), Method = HttpMethod.Post };
                    requestMessage.Headers.Add("Private-Token", gitLabAccessToken);

                    FormUrlEncodedContent encodedContent;
                    {
                        Dictionary<string, string> postParams = new Dictionary<string, string>();
                        postParams["body"] = comment.Item1.Replace("\n", "  \n");//See https://daringfireball.net/projects/markdown/syntax#p to understand why
                        postParams["created_at"] = ToISO8601Date(comment.Item2);
                        encodedContent = new FormUrlEncodedContent(postParams);
                    }
                    requestMessage.Content = encodedContent;

                    await httpClient.SendAsync(requestMessage).ContinueWith(x => Contract.Assert(x.Result.IsSuccessStatusCode));
                    Console.WriteLine("commented " + ticket.ticketid.Value);
                }
            }
        }

        static public string ToISO8601Date(DateTime dateTime) => dateTime.ToString("yyyy-MM-ddTHH:mm:ssZ");

        static public int PriorityToWeight(Priority priority)
        {
            byte weight;
            switch (priority.position.Value)
            {
                case 1:
                    weight = 9;
                    break;
                case 2:
                    weight = 4;
                    break;
                case 3:
                    weight = 2;
                    break;
                case 4:
                    weight = 1;
                    break;
                default:
                    throw new NotSupportedException();
            }
            return weight;
        }
    }
}
