using zTempo.CrossCutting.Agents.JiraProxy.Entity;

namespace zTempo.CrossCutting.Agents.JiraProxy
{
    public interface IProxyJira
    {
        public string UrlBase { get; set; }
        void Authenticate(string user, string token);
        Task<List<JiraProject>> GetProjectsByNameAsync(string name);
        Task<List<JiraIssue>> GetIssuesByNameAsync(string projectKey, string summary);
    }
}