var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.DevCraftAspire_ApiService>("apiservice")
                        .WithExternalHttpEndpoints();

builder.AddProject<Projects.DevCraftAspire_Web>("webfrontend")
       .WithReference(cache)
       .WithReference(apiService)
       .WithExternalHttpEndpoints();

builder.Build().Run();
