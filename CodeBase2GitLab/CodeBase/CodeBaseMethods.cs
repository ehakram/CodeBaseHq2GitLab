using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ToolBuddy.CodeBase2GitLab.CodeBase
{
    /// <remarks>CodeBase Api documentation https://support.codebasehq.com/kb </remarks>
    static public class CodeBaseMethods
    {
        /// <param name="accountName"> It's the XXXX in XXXX.codebasehq.com</param>
        /// <returns></returns>
        static public tickets RetrieveTickets(HttpClient client, string codeBaseApiKey, string projectName, string accountName, string userName)
        {
            //Get tickets
            tickets codeBaseTickets = null;
            {
                XmlSerializer ticketsSerializer = new XmlSerializer(typeof(tickets));
                int pageIndex = 1;
                bool reachedLastPage = false;
                while (reachedLastPage == false)
                {
                    //the API limits its answer to 20 tickets per page
                    Stream ticketsPageStream = RetrieveTicketsPage(client, codeBaseApiKey, projectName, accountName, userName, pageIndex).Result;
                    tickets ticketsPage = (tickets)ticketsSerializer.Deserialize(ticketsPageStream);

                    if (codeBaseTickets == null)
                        codeBaseTickets = ticketsPage;
                    else
                    {
                        reachedLastPage = ticketsPage.ticket == null;
                        if (reachedLastPage == false)
                            codeBaseTickets.ticket = codeBaseTickets.ticket.Concat(ticketsPage.ticket).ToArray();
                    }

                    pageIndex++;
                }
            }

            //Add notes to them
            XmlSerializer notesSerializer = new XmlSerializer(typeof(ticketnotes));
            foreach (Ticket ticket in codeBaseTickets.ticket)
            {
                int ticketId = ticket.ticketid.Value;
                ticketnotes notes = (ticketnotes)notesSerializer.Deserialize((Stream)GetNotes(client, ticketId, codeBaseApiKey, projectName, accountName, userName).Result);
                ticket.ticketnotes = notes;
            }

            return codeBaseTickets;
        }

        static public async Task<Stream> RetrieveTicketsPage(HttpClient client, string codeBaseApiKey, string projectName, string accountName, string userName, int page)
        {
            HttpRequestMessage request = new HttpRequestMessage { RequestUri = new Uri($"https://api3.codebasehq.com/{projectName}/tickets?page={page}"), Method = HttpMethod.Get };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));

            byte[] byteArray = Encoding.ASCII.GetBytes($"{accountName}/{userName}:{codeBaseApiKey}");
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            HttpResponseMessage response = await client.SendAsync(request);
            //Contract.Assert(response.IsSuccessStatusCode); Commented since I retrieve the pages until I reach one that was not found, so I will always en up receiving a response which IsSuccessStatusCode is false
            return await response.Content.ReadAsStreamAsync();
        }

        static public async Task<Stream> GetNotes(HttpClient client, int ticketId, string codeBaseApiKey, string projectName, string accountName, string userName)
        {
            HttpRequestMessage request = new HttpRequestMessage { RequestUri = new Uri($"https://api3.codebasehq.com/{projectName}/tickets/{ticketId}/notes/"), Method = HttpMethod.Get };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));

            byte[] byteArray = Encoding.ASCII.GetBytes($"{accountName}/{userName}:{codeBaseApiKey}");
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            HttpResponseMessage response = await client.SendAsync(request);
            Contract.Assert(response.IsSuccessStatusCode);
            return response.Content.ReadAsStreamAsync().Result;
        }

        static public tickets ReadTicketsFromFile(string codeBaseTicketsXmlFilePath)
        {
            XmlSerializer ticketsSerializer = new XmlSerializer(typeof(tickets));
            FileStream fileSteam = new FileStream(codeBaseTicketsXmlFilePath, FileMode.Open);
            return (tickets)ticketsSerializer.Deserialize(fileSteam);
        }

        static public void WriteTicketsToFile(string codeBaseTicketsXmlFilePath, tickets codeBaseTickets)
        {
            XmlSerializer ticketsSerializer = new XmlSerializer(typeof(tickets));
            FileStream fileSteam = new FileStream(codeBaseTicketsXmlFilePath, FileMode.Create);
            ticketsSerializer.Serialize(fileSteam, codeBaseTickets);
        }
    }
}