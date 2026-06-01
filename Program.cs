using BlazorApp1.Components;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Localization service
builder.Services.AddLocalization();

string[] supportedCulture =
[
    "en-US",
    "ta-IN"
];

var localizationOptions =
    new RequestLocalizationOptions()
        .SetDefaultCulture(supportedCulture[0])
        .AddSupportedCultures(supportedCulture)
        .AddSupportedUICultures(supportedCulture);

var app = builder.Build();

// Enable localization middleware
app.UseRequestLocalization(localizationOptions);

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapControllers();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();