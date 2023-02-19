using AutoMapper;
using System.Runtime.CompilerServices;
using zTempo.CrossCutting.Agents.JiraProxy;
using zTempo.Models;
using zTempo.Persistence.Repositories;

namespace zTempo.Application
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationRepository configurationRepository;

        public ConfigurationService(IConfigurationRepository configurationRepository)
        {
            this.configurationRepository = configurationRepository;
        }

        public List<Configuration> GetConfigurations()
        {
            var configurationsAll = configurationRepository.GetList();
            if (configurationsAll == null) return new List<Configuration>();
            return configurationsAll;
        }

        public void Save(Configuration configuration)
        {
            var issuesAll = configurationRepository.GetList();
            if (issuesAll == null) issuesAll = new List<Configuration>();

            var issue = issuesAll.Where(y => y.Field.Equals(configuration.Field)).FirstOrDefault();
            if (issue == null)
                issuesAll.Add(configuration);
            else
                issue.Value = configuration.Value;

            configurationRepository.SaveChanges(issuesAll);
        }
    }
}