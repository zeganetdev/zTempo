using zTempo.CrossCutting.Agents.JiraProxy.Entity;
using zTempo.CrossCutting.Extensions;
using zTempo.CrossCutting.RestService;

namespace zTempo.CrossCutting.Agents.JiraProxy
{
    public class ProxyJira : IProxyJira
    {
        private IRestService _restService;
        public string UrlBase { get; set; } = "https://multiplica.atlassian.net";

        public ProxyJira(IRestService restService)
        {
            _restService = restService;
        }

        public void Authenticate(string user, string token)
        {
            if (user == null || token == null) return;
            _restService.Client.SetBasicAuthentication(user, token);
        }

        public async Task<JiraUser> GetUserAsync()
        {
            string url = $"{UrlBase}/rest/api/2/myself";
            var result = await _restService.GetAsync<JiraUser>(url, new Dictionary<string, string>());
            return result;
        }

        public async Task<List<JiraIssue>> GetIssuesByNameAsync(string projectKey, string sumary)
        {
            string url = $"{UrlBase}/rest/api/2/search";
            string jql = $"project={projectKey} and summary~\"{sumary}\"";
            var result = await _restService.GetAsync<JiraResponseBase<List<JiraIssue>>>(url, new Dictionary<string, string> { { "jql", jql }, { "fields", "id,summary" } });
            return result.Issues;
        }

        public async Task<List<JiraProject>> GetProjectsByNameAsync(string name)
        {
            string url = $"{UrlBase}/rest/api/2/project/search";
            var result = await _restService.GetAsync<JiraResponseBase<List<JiraProject>>>(url, new Dictionary<string, string> { { "query", name } });
            return result.Values;
        }
    }
}