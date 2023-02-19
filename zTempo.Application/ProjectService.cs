using AutoMapper;
using zTempo.CrossCutting.Agents.JiraProxy;
using zTempo.CrossCutting.Utilities;
using zTempo.Models;
using zTempo.Persistence.Repositories;

namespace zTempo.Application
{
    public class ProjectService: IProjectService
    {
        private readonly IProxyJira proxyJira;
        private readonly IMapper mapper;
        private readonly IProjectRepository projectRepository;
        private readonly IConfigurationService configurationService;

        public ProjectService(IProxyJira proxyJira, IMapper mapper, IProjectRepository projectRepository, IConfigurationService configurationService)
        {
            this.proxyJira = proxyJira;
            this.mapper = mapper;
            this.projectRepository = projectRepository;
            this.configurationService = configurationService;
            ConfigurateJira();
        }

        private void ConfigurateJira()
        {
            var configurations = configurationService.GetConfigurations();
            var user = configurations.FirstOrDefault(x => x.Field.Equals(Constants.JIRA_EMAIL))?.Value;
            var token = configurations.FirstOrDefault(x => x.Field.Equals(Constants.JIRA_TOKEN))?.Value;
            this.proxyJira.Authenticate(user, token);
        }

        public async Task<List<Project>> GetProjectsByName(string name)
        {
            var result = await proxyJira.GetProjectsByNameAsync(name);
            return mapper.Map<List<Project>>(result);
        }

        public List<Project> GetProjects()
        {
            return projectRepository.GetList();
        }

        public void Save(List<Project> projects)
        {
            projectRepository.SaveChanges(projects);
        }
    }
}