using System.Net.Http.Json;
using zTempo.CrossCutting.Extensions;

namespace zTempo.CrossCutting.RestService
{
    public class RestService : IRestService
    {

        public HttpClient Client { get; set; }

        public RestService()
        {
            Client = new HttpClient();
        }

        public async Task<T> GetAsync<T>(string url, Dictionary<string, string> paramsQuery)
        {
            string query = string.Empty;
            foreach (var item in paramsQuery)
            {
                query += $"{item.Key}={item.Value}&";
            }
            var httpResponse = await Client.GetAsync($"{url}?{query}");
            httpResponse.EnsureSuccessStatusCode();
            return await httpResponse.Content.ReadFromJsonAsync<T>();
        }

        public async Task PostAsync<T>(string url, T body)
        {
            var httpResponse = await Client.PostAsJsonAsync(url, body);
            httpResponse.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(string url)
        {
            var httpResponse = await Client.DeleteAsync(url);
            httpResponse.EnsureSuccessStatusCode();
        }
    }
}