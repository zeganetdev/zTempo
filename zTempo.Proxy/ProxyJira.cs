using zTempo.CrossCutting.RestService;

namespace zTempo.Proxy
{
    public class ProxyJira : IProxyJira
    {
        private IRestService _restService;
        public ProxyJira(IRestService restService)
        {
            _restService = restService;
        }

        public T GetProjectsByName<T>(string name)
        {
            return _restService.Get<T>();
        }
    }
}