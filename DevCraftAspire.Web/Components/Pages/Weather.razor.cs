using DevCraftAspire.Web.Models;

namespace DevCraftAspire.Web.Components.Pages;

public partial class Weather
{
    private WeatherForecast[]? _forecasts;

    protected override async Task OnInitializedAsync()
    {
        _forecasts = await WeatherApi.GetWeatherAsync();
    }
}