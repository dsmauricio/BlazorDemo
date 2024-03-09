using BlazorDemo.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using BlazorDemo.UI.Services;

namespace BlazorDemo.UI.Pages
{
    public partial class Weather
    {
        private WeatherForecast[]? forecasts;

        [Inject]
        public IWeatherService _client { get; init; } = default!;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                forecasts = await _client.GetForecastAsync();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }
    }
}
