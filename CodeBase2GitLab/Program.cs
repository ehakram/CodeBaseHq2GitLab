using System;
using System.Net.Http;
using ToolBuddy.CodeBase2GitLab.CodeBase;
using ToolBuddy.CodeBase2GitLab.GitLab;

namespace ToolBuddy.CodeBase2GitLab
{
    class Program
    {
        static private void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            tickets codeBaseTickets = CodeBaseMethods.RetrieveTickets(httpClient, "codeBaseApiKey", "projectName", "accountName", "userName");
            //CodeBaseMethods.WriteTicketsToFile("myTickets.xml", codeBaseTickets);
            //tickets codeBaseTickets = CodeBaseMethods.ReadTicketsFromFile("myTickets.xml");
            GitLabMethods.UploadGitLabTickets(httpClient, codeBaseTickets.ticket, "gitLabAccessToken", "projectName", "userName");
            Console.ReadKey();
        }
    }
}
