using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.CrossCutting.Agents.TempoProxy;
using zTempo.CrossCutting.Agents.TempoProxy.Entity;
using zTempo.CrossCutting.Utilities;
using zTempo.Models;

namespace zTempo.Application
{
    public class WorklogService : IWorklogService
    {
        private readonly IProxyTempo proxyTempo;
        private readonly IMapper mapper;
        private readonly IConfigurationService configurationService;
        public WorklogService(IProxyTempo proxyTempo, IMapper mapper, IConfigurationService configurationService)
        {
            this.proxyTempo = proxyTempo ?? throw new ArgumentNullException(nameof(proxyTempo));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.configurationService = configurationService ?? throw new ArgumentNullException(nameof(configurationService));
            ConfigurateTempo();
        }
        private void ConfigurateTempo()
        {
            var configurations = configurationService.GetConfigurations();
            var token = configurations.FirstOrDefault(x => x.Field.Equals(Constants.TEMPO_TOKEN))?.Value;
            this.proxyTempo.Authenticate(token);
        }
        public async Task<List<Worklogs>> GetListByDateAsync(string accountId, string date)
        {
            var result = await proxyTempo.GetListByDateAsync(accountId, date);
            return mapper.Map<List<Worklogs>>(result);;
        }

        public async Task SaveAsync(Worklog worklog)
        {
            var entity = mapper.Map<TempoWorklog>(worklog);
            await proxyTempo.SaveAsync(entity);
        }
    }
}
