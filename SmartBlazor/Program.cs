/**
 * 
 * Project SmartBlazor
 * Copyright (C) 2022-23 Alessio Saltarin 'alessiosaltarin@gmail.com'
 * This software is licensed under MIT License. See LICENSE.
 * 
 **/

using SmartBlazor.Data;
using SmartBlazor.Service;
using Microsoft.EntityFrameworkCore;
using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Services tied to HTTP Session
builder.Services.AddScoped<ISiteUserService, SiteUserService>();
builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();
builder.Services.AddScoped<ISessionService, SessionService>();

// Charts and UI
builder.Services
    .AddBlazorise( options =>
    {
        options.Immediate = true;
    } )
    .AddBulmaProviders()
    .AddFontAwesomeIcons();

// EF Core 
builder.Services.AddDbContextFactory<SmartBlazorDbContext>(opt =>
    opt.UseSqlite($"Data Source={SmartBlazorDbContext.DbPath}"));

// Logger
builder.Logging.ClearProviders();
builder.Logging.AddSimpleConsole(options =>
{
    options.IncludeScopes = true;
    options.SingleLine = true;
    options.TimestampFormat = "HH:mm:ss.ffff ";
});

WebApplication app = builder.Build();

// Populate DB
await using var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateAsyncScope();
var options = scope.ServiceProvider.GetRequiredService<DbContextOptions<SmartBlazorDbContext>>();
await DatabaseUtils.EnsureDbCreatedAndSeedAsync(options, 10);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
