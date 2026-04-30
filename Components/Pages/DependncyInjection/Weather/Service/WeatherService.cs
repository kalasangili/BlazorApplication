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
            List<float> TempCList = new List<float> { 30.2f, 20.5f, 17.9f, 32.6f, 40.8f, 27.2f };
            List<string> SessionList = new List<string> { "Cloudy", "Rainy", "Sunny", "Mist", "VeryHot" };
            for (int i = 1; i <= 5; i++)
            {
                float tempC = TempCList[Random.Shared.Next(TempCList.Count)];
                WeatherData._weatherDetails.Add(new WeatherDetails
                {
                    Date = DateTime.UtcNow.AddDays(i),    
                    TempC = tempC,
                    TempF = (tempC * (9f/5f)) + 32f,
                    Session = SessionList[Random.Shared.Next(SessionList.Count)]
                });
            }

        }
    }
}
