using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using zTempo.CrossCutting.Agents.JiraProxy.Entity;
using zTempo.CrossCutting.Agents.TempoProxy.Entity;
using zTempo.CrossCutting.Extensions;
using zTempo.CrossCutting.RestService;

namespace zTempo.CrossCutting.Agents.TempoProxy
{
    public class ProxyTempo : IProxyTempo
    {
        private readonly IRestService _restService;
        public string UrlBase { get; set; } = "https://api.tempo.io";

        public ProxyTempo(IRestService restService)
        {
            _restService = restService;
        }

        public void Authenticate(string token)
        {
            _restService.Client.SetBearerToken(token);
        }

        public async Task<List<TempoWorklogs>> GetListByDateAsync(string accountId, string date)
        {
            string url = $"{UrlBase}/4/worklogs/user/{accountId}";
            var query = new Dictionary<string, string> { { "from", date }, { "to", date } };
            var result = await _restService.GetAsync<TempoResponseBase<List<TempoWorklogs>>>(url, query);
            return result.Results;
        }
        public async Task SaveAsync(TempoWorklog tempoWorklog)
        {
            string url = $"{UrlBase}/4/worklogs";
            await _restService.PostAsync(url, tempoWorklog);
        }

    }
}
