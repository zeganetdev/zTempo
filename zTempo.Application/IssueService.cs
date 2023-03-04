using AutoMapper;
using System.Runtime.CompilerServices;
using zTempo.CrossCutting.Agents.JiraProxy;
using zTempo.CrossCutting.Utilities;
using zTempo.Models;
using zTempo.Persistence.Repositories;

namespace zTempo.Application
{
    public class IssueService: IIssueService
    {
        private readonly IProxyJira proxyJira;
        private readonly IMapper mapper;
        private readonly IIssueRepository issueRepository;
        private readonly IConfigurationService configurationService;

        public IssueService(IProxyJira proxyJira, IMapper mapper, IIssueRepository issueRepository, IConfigurationService configurationService)
        {
            this.configurationService = configurationService;
            this.proxyJira = proxyJira;
            this.mapper = mapper;
            this.issueRepository = issueRepository;
            ConfigurateJira();
        }

        private void ConfigurateJira()
        {
            var configurations = configurationService.GetConfigurations();
            var user = configurations.FirstOrDefault(x => x.Field.Equals(Constants.JIRA_EMAIL))?.Value;
            var token = configurations.FirstOrDefault(x => x.Field.Equals(Constants.JIRA_TOKEN))?.Value;
            proxyJira.Authenticate(user, token);
        }

        public async Task<List<Issue>> GetIssuesByName(string projectKey, string summary)
        {
            var result = await proxyJira.GetIssuesByNameAsync(projectKey, summary);
            return mapper.Map<List<Issue>>(result);
        }

        public List<Issue> GetIssues(string projectId)
        {
            var issuesAll = issueRepository.GetList();
            if (issuesAll == null) return new List<Issue>();
            return issuesAll.Where(x => x.ProjectId.Equals(projectId)).ToList();
        }

        public void Save(List<Issue> issues)
        {
            var issuesAll = issueRepository.GetList();
            if (issuesAll == null) issuesAll = new List<Issue>();

            issues.ForEach(x =>
            {
                var issue = issuesAll.Where(y => y.Id.Equals(x.Id)).FirstOrDefault();
                if (issue == null) issuesAll.Add(x);
            });

            issueRepository.SaveChanges(issuesAll);
        }
    }
}