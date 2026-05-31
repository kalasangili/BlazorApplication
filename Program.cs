using BlazorApp1.Components;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddLocalization();

string[] supportedCulture =
[
    "en-US",
    "ta-IN",
    "hi-IN"
];

var localizationOptions =
    new RequestLocalizationOptions()
        .SetDefaultCulture("en-US")
        .AddSupportedCultures(supportedCulture)
        .AddSupportedUICultures(supportedCulture);

var app = builder.Build();

app.UseRequestLocalization(localizationOptions);

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapControllers();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();