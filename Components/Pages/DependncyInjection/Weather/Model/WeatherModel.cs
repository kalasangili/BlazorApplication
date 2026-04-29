namespace BlazorApp1.Components.Pages.DependncyInjection.Weather.Model
{
	public class WeatherModel
	{
		public string? Place { get; set; }
		public List<WeatherDetails> _weatherDetails { get; set; }
	}
    public class WeatherDetails
    {

        public DateTime Date { get; set; }
		public float TempC { get; set; } 
		public float TempF { get; set; } 
		public string? Session { get; set; } 


	}

}
