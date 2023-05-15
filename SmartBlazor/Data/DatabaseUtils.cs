/**
* 
* Project SmartBlazor
* Copyright (C) 2022-23 Alessio Saltarin 'alessiosaltarin@gmail.com'
* This software is licensed under MIT License. See LICENSE.
* 
**/

using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace SmartBlazor.Data;

public static class DatabaseUtils
{

    /// <summary>
    /// Method to populate the database
    /// </summary>
    /// <param name="options">The configured options.</param>
    /// <param name="count">The number of contacts to seed.</param>
    /// <returns>The <see cref="Task"/>.</returns>
    public static async Task EnsureDbCreatedAndSeedAsync(
        DbContextOptions<SmartBlazorDbContext> options, int count)
    {
        Debug.WriteLine("Seeding DB");
        var builder = new DbContextOptionsBuilder<SmartBlazorDbContext>(options);

        await using var context = new SmartBlazorDbContext(builder.Options);

        var seed = new SeedWeatherForecasts();
        await seed.SeedDatabaseWithWeatherForecastsAsync(context, count);
    }
    
}

