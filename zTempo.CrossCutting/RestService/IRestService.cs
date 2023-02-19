using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zTempo.CrossCutting.RestService
{
    public interface IRestService
    {
        HttpClient Client { get; set; }
        Task<T> GetAsync<T>(string url, Dictionary<string, string> paramsQuery);
        Task PostAsync<T>(string url, T entity);
    }
}
