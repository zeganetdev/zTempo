using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zTempo.CrossCutting.Agents.TempoProxy.Entity;

namespace zTempo.CrossCutting.Agents.TempoProxy
{
    public interface IProxyTempo
    {
        public string UrlBase { get; set; }
        void Authenticate(string token);
        Task DeleteAsync(int tempoWorklogId);
        Task<List<TempoWorklogs>> GetListByDateAsync(string accountId, string date);
        Task SaveAsync(TempoWorklog tempoWorklog);
    }
}
