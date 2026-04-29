using BlazorApp1.Components.Pages.DependncyInjection.Weather.Model;

namespace BlazorApp1.Components.Pages.DependncyInjection.Weather.Service
{
    public class WeatherService : IWeatherService
    {
        public WeatherModel WeatherData { get; set; } = new WeatherModel
        {
            Place = "Chennai",
			_weatherDetails = new List<WeatherDetails>()
        };

        public WeatherService()
        {

            for (int i = 1; i <= 5; i++)
            {
                WeatherData._weatherDetails.Add(new WeatherDetails
                {
                    Date = DateTime.Now,
                    TempC = 30,
                    TempF = 86,
                    Session = "Morning"
                });



            }




        }
    }
}
