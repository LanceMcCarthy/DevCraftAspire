using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Diagnostics;
using Telerik.Reporting.Cache.File;
using Telerik.Reporting.Services;

var builder = WebApplication.CreateBuilder(args);

// Comes from ServiceDefaults project's extensions
builder.AddServiceDefaults();

// For traces
builder.AddSeqEndpoint("seq");

// Add services to the container.
builder.Services.AddProblemDetails();

// For Telerik Reporting REST service (ReportsController uses jsonNet)
builder.Services.AddControllers(opts => { })
    .AddNewtonsoftJson(opts => { })
    .AddJsonOptions(opts => { });

// CORs policy to allow the ReportViewer in the front-end project to use the REST API in a different domain
builder.Services.AddCors(corsOption => corsOption.AddPolicy("ReportingRestPolicy", corsBuilder => corsBuilder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()));

// Reporting setup, with a Uri resolver
builder.Services.TryAddSingleton<IReportServiceConfiguration>(sp =>
{
    var rootPath = sp.GetService<IWebHostEnvironment>()?.ContentRootPath;

    if (string.IsNullOrEmpty(rootPath))
        rootPath = "./";

    return new ReportServiceConfiguration
    {
        ReportingEngineConfiguration = sp.GetService<IConfiguration>(),
        HostAppId = "MyAspireApp",
        Storage = new FileStorage(),
        ReportSourceResolver = new UriReportSourceResolver(Path.Combine(rootPath, "Reports"))
    };
});

var app = builder.Build();

app.UseExceptionHandler();

app.UseStaticFiles();
app.MapControllers();
app.UseCors("ReportingRestPolicy");

app.MapDefaultEndpoints();

// FOR TROUBLESHOOTING IN AZURE
//#if RELEASE
//var logFilePath = Path.Join("/home/app", "traceoutput.log");
//Trace.Listeners.Add(new TextWriterTraceListener(logFilePath, "myListener"));
//Trace.AutoFlush = true;
//#endif


app.Run();
