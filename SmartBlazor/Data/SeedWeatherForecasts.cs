

using System.Diagnostics;
/**
* 
* Project SmartBlazor
* Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
* This software is licensed under MIT License. See LICENSE.
* 
**/
namespace SmartBlazor.Data
{
    public class SeedWeatherForecasts
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecast[] GetForecasts(DateTime startDate, int totalCount)
        {
            return Enumerable.Range(1, totalCount).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();
        }

        public async Task SeedDatabaseWithWeatherForecastsAsync(SmartBlazorDbContext context, int totalCount)
        {
            Debug.WriteLine("Seeding Weather Forecasts...");
            if ((context.WeatherForecasts == null)||!context.WeatherForecasts.Any())
            {
                var forecasts = this.GetForecasts(DateTime.Now, totalCount);
                context.WeatherForecasts?.AddRange(forecasts);
                await context.SaveChangesAsync();
            }
            else
            {
                Debug.WriteLine("Weather Forecasts table already populated...");

            }
        }

    }


}
