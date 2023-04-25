using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Core.Services
{
    public enum GetTypeQuery
    {
       ByQuery,
       ById
    }

    public interface INetworkService
	{
		public Task<T> Get<T>(string endpoint, GetTypeQuery type);
	}

    public class NetworkService : INetworkService
	{

		static string appID = "&appid=439d4b804bc8187953eb36d2a8c26a02";
		static string baseURL = "https://openweathermap.org/data/2.5/";

		HttpClient client;

        public NetworkService()
		{
			client = new HttpClient();
		}

        public async Task<T> Get<T>(string endpoint, GetTypeQuery type)
        {
            var response = new HttpResponseMessage();
            try
            {
                var query = type switch
                {
                    GetTypeQuery.ByQuery => "find?q",
                    GetTypeQuery.ById => "weather?id",
                    _ => "find?q"
                };
                string url = $"{baseURL}{query}={endpoint}{appID}";
                var formattedURL = Uri.EscapeUriString(url);
                response = await client.GetAsync(formattedURL);
                return await response.Content.ReadFromJsonAsync<T>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

