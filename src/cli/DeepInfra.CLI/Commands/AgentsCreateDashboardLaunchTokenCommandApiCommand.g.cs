#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class AgentsCreateDashboardLaunchTokenCommandApiCommand
{
    private static Argument<string> InstanceId { get; } = new(
        name: @"instance-id")
    {
        Description = @"",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<string?> XApiKey { get; } = new(
        name: @"--x-api-key")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.OpenClawLaunchTokenOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.OpenClawLaunchTokenOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-dashboard-launch-token", @"Create Dashboard Launch Token
Mint a single-use launch URL for the dashboard.

Called by the launcher page right when readyz flips ready. The launch URL
is used as a top-level navigation; /launch then sets the oc_auth cookie
and 302s into the proxied dashboard.

The user's bearer token is stashed in Redis under the token's jti and
retrieved (atomic GETDEL) on /launch redeem — this keeps the bearer out of
the URL and out of any signed payload while preserving the existing proxy
auth flow (oc_auth cookie value = bearer token).

Refuses instances whose agent_type has has_dashboard=False (e.g. hermes).");
                        command.Arguments.Add(InstanceId);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var instanceId = parseResult.GetRequiredValue(InstanceId);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Agents.CreateDashboardLaunchTokenAsync(
                                    instanceId: instanceId,
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::DeepInfra.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}