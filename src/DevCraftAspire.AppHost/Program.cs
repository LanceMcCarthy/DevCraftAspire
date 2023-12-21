using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

var apiService = builder.AddProject<Projects.DevCraftAspire_ApiService>("apiservice");

builder.AddProject<Projects.DevCraftAspire_Web>("webfrontend")
    .WithReference(cache)
    .WithReference(apiService);

builder.Build().Run();
