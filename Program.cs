using BlazorApp1.Components;
using BlazorApp1.Components.Pages.Localization.services;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddLocalization();

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});
builder.Services.AddScoped<CultureService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapControllers();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

var supportedCultures = new[]
{
    new CultureInfo("en"),
    new CultureInfo("ta"),
    new CultureInfo("hi")
};


app.UseRequestLocalization(
    new RequestLocalizationOptions
    {
        DefaultRequestCulture =
            new Microsoft.AspNetCore.Localization.RequestCulture("en"),

        SupportedCultures = supportedCultures,
        SupportedUICultures = supportedCultures
    });

app.Run();