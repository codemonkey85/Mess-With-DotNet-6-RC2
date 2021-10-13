namespace BlazorApp3.Pages;

[Route("fetchdata")]
public partial class FetchData
{
    [Inject] private WeatherService? WeatherService { get; set; }

    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync() => forecasts = WeatherService == null ? null : await WeatherService.GetWeatherForecasts();
}
