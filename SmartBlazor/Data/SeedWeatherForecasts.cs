/**
* 
* Project SmartBlazor
* Copyright (C) 2022-23 Alessio Saltarin 'alessiosaltarin@gmail.com'
* This software is licensed under MIT License. See LICENSE.
* 
**/

using SmartBlazor.Data.Model;
using System.Diagnostics;

namespace SmartBlazor.Data;

public class SeedWeatherForecasts
{
    public static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    public async Task SeedDatabaseWithWeatherForecastsAsync(SmartBlazorDbContext context, int totalCount)
    {
        Debug.WriteLine("Seeding Weather Forecasts...");
        if ((context.WeatherForecasts == null)||!context.WeatherForecasts.Any())
        {
            WeatherForecast[] forecasts = GetForecasts(DateTime.Now, totalCount);
            context.WeatherForecasts?.AddRange(forecasts);
            await context.SaveChangesAsync();
        }
        else
        {
            Debug.WriteLine("Weather Forecasts table already populated...");

        }
    }
    
    public static WeatherForecast[] GetForecasts(DateTime startDate, int totalCount)
    {
        return Enumerable.Range(1, totalCount).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray();
    }

}



