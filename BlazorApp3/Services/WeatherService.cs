using System.Net.Http.Json;

namespace BlazorApp3.Services
{
    public class WeatherService
    {
        private HttpClient HttpClient { get; set; }

        public WeatherService(HttpClient httpClient) => HttpClient = httpClient;

        public async Task<WeatherForecast[]?> GetWeatherForecasts() => await HttpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }
}
