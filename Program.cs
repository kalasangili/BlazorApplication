using BlazorApp1.Components;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});


builder.Services.AddScoped<CultureService>();


var app = builder.Build();


app.UseHttpsRedirection();

app.UseStaticFiles();


// IMPORTANT: before Razor Components
var supportedCultures = new[]
{
    new CultureInfo("en"),
    new CultureInfo("ta"),
    new CultureInfo("hi")
};


app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
});


app.UseAntiforgery();


app.MapControllers();


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


app.Run();