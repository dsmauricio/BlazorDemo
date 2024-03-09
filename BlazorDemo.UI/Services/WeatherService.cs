using BlazorDemo.Shared;
using System.Net.Http.Json;

namespace BlazorDemo.UI.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _http;

        public WeatherService(HttpClient http)
        {
            _http = http;
        }

        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            var weatherArray = await _http.GetFromJsonAsync<WeatherForecast[]>("weatherforecast");

            return weatherArray ?? [];
        }
    }
}
