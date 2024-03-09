using BlazorDemo.Shared;

namespace BlazorDemo.UI.Services
{
    public interface IWeatherService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}