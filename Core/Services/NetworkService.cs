using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Core.Services
{

	public interface INetworkService
	{
		public Task<T> Get<T>(string endpoint);
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

        public async Task<T> Get<T>(string endpoint)
        {
            var response = new HttpResponseMessage();
            try
            {
                string url = $"{baseURL}find?q={endpoint}{appID}";
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

