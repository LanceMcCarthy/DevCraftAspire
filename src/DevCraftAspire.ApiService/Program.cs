using Microsoft.Extensions.DependencyInjection.Extensions;
using Telerik.Reporting.Cache.File;
using Telerik.Reporting.Services;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

builder.Services.AddControllers(opts => { })
    .AddNewtonsoftJson(opts => { }) // Note: for ReportsController
    .AddJsonOptions(opts => { });

builder.Services.AddCors(corsOption => corsOption
    .AddPolicy("ReportingRestPolicy", corsBuilder => corsBuilder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
));

builder.Services.TryAddSingleton<IReportServiceConfiguration>(sp =>
{
    var rootPath = sp.GetService<IWebHostEnvironment>()?.ContentRootPath;

    if (string.IsNullOrEmpty(rootPath))
    {
        rootPath = "./";
    }

    return new ReportServiceConfiguration
    {
        ReportingEngineConfiguration = sp.GetService<IConfiguration>(),
        HostAppId = "MyAspireApp",
        Storage = new FileStorage(),
        ReportSourceResolver = new UriReportSourceResolver(Path.Combine(rootPath, "Reports"))
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.UseStaticFiles();
app.MapControllers();
app.UseCors("ReportingRestPolicy");

app.MapDefaultEndpoints();

app.Run();
