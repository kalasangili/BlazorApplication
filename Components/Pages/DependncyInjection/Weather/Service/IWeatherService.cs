using BlazorApp1.Components.Pages.DependncyInjection.Weather.Model;

namespace BlazorApp1.Components.Pages.DependncyInjection.Weather.Service
{
    public interface IWeatherService
    {
        public WeatherModel WeatherData { get; set; }
    }
}
