using Atico.Atico_web.Components;
using Atico_Services.Services.Plugins;
using Atico_Shared.Interfaces;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// Register services
builder.Services.AddScoped<IViewTemplateService, ViewTemplateService>();
builder.Services.AddScoped<IViewData_Repository, ViewData_Repository>();
builder.Services.AddScoped<IViewData_set, ViewObject>();
builder.Services.AddScoped<IViewData, Brand>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
