using DevCraftAspire.Web.Clients;
using DevCraftAspire.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();
builder.AddRedisOutputCache("cache");

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

// Note, you can use "https+http://apiservice" to denote https preference, see https://aka.ms/dotnet/sdschemes.
builder.Services.AddHttpClient<WeatherApiClient>(client=> client.BaseAddress = new("https+http://apiservice"));
builder.Services.AddHttpClient<ReportsApiClient>(client=> client.BaseAddress = new("https+http://apiservice"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();
app.UseOutputCache();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
app.MapDefaultEndpoints();

app.Run();
