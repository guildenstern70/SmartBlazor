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
        public DbSet<WeatherForecast> WeatherForecast { get; set; }
        public DbSet<SiteUser> SiteUsers { get; set; }

        public string DbPath { get; }

        public SmartBlazorDbContext()
        {
            DbPath = System.IO.Path.Join(".", "smartblazor.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
