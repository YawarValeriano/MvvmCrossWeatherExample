using System;
using System.Threading.Tasks;
using Core.Models;
using Core.Services;

namespace Core.Repositories
{
	public interface IWeatherRepository
	{
		Task<WeatherResponse> FindWeatherResultsByName(string locationName);
		Task<ListResult> FindWeatherById(int id);
	}

	public class WeatherRepository : IWeatherRepository
	{
		private readonly INetworkService _service;

		public WeatherRepository(INetworkService service)
		{
			this._service = service;
		}

        public Task<WeatherResponse> FindWeatherResultsByName(string locationName)
        {
			try
			{
                var result = _service.Get<WeatherResponse>(locationName, GetTypeQuery.ByQuery);
				return result;
            } catch (Exception e)
			{
				throw e;
			}
        }

        public Task<ListResult> FindWeatherById(int id)
        {
            try
            {
                var result = _service.Get<ListResult>(id.ToString(), GetTypeQuery.ById);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

