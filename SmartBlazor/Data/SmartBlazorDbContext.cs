/**
* 
* Project SmartBlazor
* Copyright (C) 2021 Alessio Saltarin 'alessiosaltarin@gmail.com'
* This software is licensed under MIT License. See LICENSE.
* 
**/

using Microsoft.EntityFrameworkCore;

namespace SmartBlazor.Data
{
    public class SmartBlazorDbContext : DbContext
    {
        public DbSet<WeatherForecast>? WeatherForecasts { get; set; }
        public DbSet<SiteUser>? SiteUsers { get; set; }

        public static readonly string DbPath = System.IO.Path.Join(".", "smartblazor.db");

        public SmartBlazorDbContext(DbContextOptions<SmartBlazorDbContext> options)
            : base(options)
        {
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        /// <summary>
        /// Dispose pattern.
        /// </summary>
        public override void Dispose()
        {
            base.Dispose();
        }

        /// <summary>
        /// Dispose pattern.
        /// </summary>
        /// <returns>A <see cref="ValueTask"/></returns>
        public override ValueTask DisposeAsync()
        {
            return base.DisposeAsync();
        }
    }
}
