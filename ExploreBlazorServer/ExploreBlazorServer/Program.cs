using ExploreBlazorServer.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

//Below commented lines will help us to configure the logging system, similar to configuration in appsettings.Development.json
//builder.Logging.ClearProviders();
//builder.Logging.AddConsole();
//builder.Logging.AddDebug();
//builder.Logging.SetMinimumLevel(LogLevel.Debug);

//For adding configuration
//builder.Configuration.AddConfiguration()

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//To access WeatherForecastService in any of the razor page
//Refer fetch data for usage
builder.Services.AddTransient<WeatherForecastService>();

//builder.Services.AddSingleton<IDummyData, DummyData>();//Same instance across all users and session
//builder.Services.AddScoped<IDummyData, DummyData>();//New instance per session
//builder.Services.AddTransient<IDummyData, DummyData>();//Every time when this is called, a new instance is created irrespetive of same session or different session
builder.Services.AddTransient<DummyData>();

builder.Services.AddScoped<ICounterService, CounterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();//Establishes signalR connection between client and web server
app.MapFallbackToPage("/_Host");

app.Run();
