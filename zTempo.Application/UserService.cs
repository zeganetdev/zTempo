using AutoMapper;
using System.Runtime.CompilerServices;
using zTempo.CrossCutting.Agents.JiraProxy;
using zTempo.CrossCutting.Utilities;
using zTempo.Models;
using zTempo.Persistence.Repositories;

namespace zTempo.Application
{
    public class UserService : IUserService
    {
        private readonly IProxyJira proxyJira;
        private readonly IConfigurationService configurationService;
        private readonly IUserRepository userRepository;

        private readonly IMapper mapper;

        public UserService(IProxyJira proxyJira, IConfigurationService configurationService, IMapper mapper, IUserRepository userRepository)
        {
            this.proxyJira = proxyJira;
            this.configurationService = configurationService;
            this.userRepository = userRepository;
            this.mapper = mapper;
            ConfigurateJira();
        }

        public void ConfigurateJira()
        {
            var configurations = configurationService.GetConfigurations();
            var user = configurations.FirstOrDefault(x => x.Field.Equals(Constants.JIRA_EMAIL))?.Value;
            var token = configurations.FirstOrDefault(x => x.Field.Equals(Constants.JIRA_TOKEN))?.Value;
            this.proxyJira.Authenticate(user, token);
        }

        public User GetUser()
        {
            var user = userRepository.GetList();
            return user.FirstOrDefault();
        }

        public async Task<User> GetUserAsync()
        {
            var result = await proxyJira.GetUserAsync();
            return mapper.Map<User>(result); ;
        }

        public void Save(User user)
        {
            userRepository.SaveChanges(new List<User> { user });
        }
    }
}