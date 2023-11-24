﻿using DevCraftAspire.ApiService.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCraftAspire.ApiService.Controllers;

[Route("/weatherforecast")]
[ApiController]
public class WeatherController : ControllerBase
{
    string[] summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public ActionResult<WeatherForecast[]> Get()
    {
        var forecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast(
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)])).ToArray();

        return forecast;
    }
}
