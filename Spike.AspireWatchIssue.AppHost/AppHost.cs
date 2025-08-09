var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Spike_AspireWatchIssue_Api>("webapi");
builder.AddProject<Projects.Spike_AspireWatchIssue_Web_BlazorWasm>("webfrontend");
builder.Build().Run();
