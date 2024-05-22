var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var seq = builder.AddSeq("seq");

var apiService = builder.AddProject<Projects.DevCraftAspire_ApiService>("apiservice")
    .WithReference(seq)
    .WithExternalHttpEndpoints();

builder.AddProject<Projects.DevCraftAspire_Web>("webfrontend")
    .WithReference(cache)
    .WithReference(apiService)
    .WithReference(seq)
    .WithExternalHttpEndpoints();

builder.Build().Run();
