# NullReferenceException in ApplyManagedCodeUpdates when running dotnet or aspire watch against Aspire AppHost
This repository is a minimal example of the issue described in the [Aspire issue TBD]().

## Reproduction Steps
1. Clone the repository.
2. Navigate to the project directory.
3. Run the command `dotnet watch` or `aspire run --watch` in the `Spike.AspireWatchIssue.AppHost` directory.
4. Observe the `NullReferenceException` that occurs during the application startup.

