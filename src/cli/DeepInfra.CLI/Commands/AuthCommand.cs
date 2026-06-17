#nullable enable

using System.CommandLine;
using System.Text.Json.Serialization;

namespace DeepInfra.CLI.Commands;

internal static class AuthCommand
{
    public static Command Create()
    {
        var command = new Command("auth", "Inspect and manage API credentials used by the generated CLI.");
        command.Subcommands.Add(CreateSetCommand());
        command.Subcommands.Add(CreateStatusCommand());
        command.Subcommands.Add(CreateClearCommand());
        return command;
    }

    private static Command CreateSetCommand()
    {
        var apiKeyArgument = new Argument<string>("api-key") { Description = "API key to store." };
        var command = new Command("set", "Store an API key in dotnet user-secrets.");
        command.Arguments.Add(apiKeyArgument);
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                var apiKey = parseResult.GetValue(apiKeyArgument) ?? throw new CliException("API key is required.");
                await CliRuntime.WriteUserSecretAsync(CliRuntime.GetUserSecretApiKeyName(), apiKey, cancellationToken).ConfigureAwait(false);
                await Console.Out.WriteLineAsync($"Stored API key ({CliRuntime.MaskSecret(apiKey)}) at {CliRuntime.GetUserSecretsPath()}.").ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }

    private static Command CreateStatusCommand()
    {
        var command = new Command("status", "Show the authentication source order the CLI will use.");
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                var status = await CliRuntime.GetAuthStatusAsync(parseResult, cancellationToken).ConfigureAwait(false);
                if (parseResult.GetValue(CliOptions.Json))
                {
                    await CliRuntime.WriteJsonAsync(
                        parseResult,
                        status,
                        UserSecretsJsonContext.Default,
                        cancellationToken).ConfigureAwait(false);
                    return;
                }

                await Console.Out.WriteLineAsync($"authenticated: {(status.Authenticated ? "true" : "false")}").ConfigureAwait(false);
                await Console.Out.WriteLineAsync($"source: {status.Source}").ConfigureAwait(false);
                if (!string.IsNullOrWhiteSpace(status.ApiKeyHint))
                {
                    await Console.Out.WriteLineAsync($"api-key: {status.ApiKeyHint}").ConfigureAwait(false);
                }
                if (!string.IsNullOrWhiteSpace(status.Path))
                {
                    await Console.Out.WriteLineAsync($"path: {status.Path}").ConfigureAwait(false);
                }
                await Console.Out.WriteLineAsync("sources:").ConfigureAwait(false);
                foreach (var source in status.Sources)
                {
                    var line = $"  - {source.DisplayName}: {(source.Present ? "set" : "not present")}";
                    if (!string.IsNullOrWhiteSpace(source.ApiKeyHint))
                    {
                        line += $" ({source.ApiKeyHint})";
                    }
                    if (!string.IsNullOrWhiteSpace(source.Path))
                    {
                        line += $" [{source.Path}]";
                    }

                    await Console.Out.WriteLineAsync(line).ConfigureAwait(false);
                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }

    private static Command CreateClearCommand()
    {
        var command = new Command("clear", "Clear the API key stored in dotnet user-secrets.");
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                await CliRuntime.ClearUserSecretAsync(CliRuntime.GetUserSecretApiKeyName(), cancellationToken).ConfigureAwait(false);
                await Console.Out.WriteLineAsync($"Cleared API key at {CliRuntime.GetUserSecretsPath()}.").ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}