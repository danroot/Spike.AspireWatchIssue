# NullReferenceException in ApplyManagedCodeUpdates when running dotnet or aspire watch against Aspire AppHost
This repository is a minimal example of the issue described in the [Aspire issue TBD]().

## Reproduction Steps
1. Clone the repository.
1. Navigate to the project directory.
1. Run `dotnet run --project ./Spike.AspireWatchIssue.AppHost/Spike.AspireWatchIssue.AppHost.csproj`
1. Observe that the application starts successfully.
1. Stop the application.
1. Run `dotnet watch --project ./Spike.AspireWatchIssue.Web.BlazorWasm/Spike.AspireWatchIssue.BlazorWasm.csproj`
1. Observe that the application starts successfully.
1. Change the `Home.razor` file in the `Spike.AspireWatchIssue.Web.BlazorWasm` 
1. Observe that the application updates successfully.
1. Stop the application.
1. Run `dotnet watch --project ./Spike.AspireWatchIssue.AppHost/Spike.AspireWatchIssue.AppHost.csproj`
1. Observe the error message indicating a `NullReferenceException` in `BlazorWebAssemblyDeltaApplier.WaitForProcessRunningAsync`.

```
dotnet watch ❌ [Spike.AspireWatchIssue.AppHost (net9.0)] Exited with error code 143
dotnet watch ❌ System.NullReferenceException: Object reference not set to an instance of an object.
   at Microsoft.DotNet.Watch.BlazorWebAssemblyDeltaApplier.WaitForProcessRunningAsync(CancellationToken cancellationToken)
   at Microsoft.DotNet.Watch.RunningProject.WaitForProcessRunningAsync(CancellationToken cancellationToken)
   at Microsoft.DotNet.Watch.HotReloadDotNetWatcher.WatchAsync(CancellationToken shutdownCancellationToken)
   at Microsoft.DotNet.Watch.HotReloadDotNetWatcher.WatchAsync(CancellationToken shutdownCancellationToken)
   at Microsoft.DotNet.Watch.HotReloadDotNetWatcher.WatchAsync(CancellationToken shutdownCancellationToken)
   at Microsoft.DotNet.Watch.Program.RunAsync()
dotnet watch ❌ An unexpected error occurred
```
