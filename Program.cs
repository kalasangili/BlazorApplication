using BlazorApp1.Components;
using BlazorApp1.Components.Pages.Blog.Services;
using BlazorApp1.Components.Pages.DependncyInjection.Todo.Services;
using BlazorApp1.Components.Pages.DependncyInjection.Weather.Service;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Blog - (Routing)
builder.Services.AddSingleton<BlogService>();

// Todo - (DI)
builder.Services.AddTransient<ITodoService, TodoService>();

//Weather -(DI)
builder.Services.AddScoped<IWeatherService, WeatherService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
