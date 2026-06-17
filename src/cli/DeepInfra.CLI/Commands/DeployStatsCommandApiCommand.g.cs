#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class DeployStatsCommandApiCommand
{
    private static Argument<string> DeployId { get; } = new(
        name: @"deploy-id")
    {
        Description = @"",
    };

    private static Option<string> From { get; } = new(
        name: @"--from")
    {
        Description = @"start of period, unix ts or 'now-5h', supported units s(ec), m(min), h(our), d(ay), w(eek), M(onth)",
        Required = true,
    };

    private static Option<string?> To { get; } = new(
        name: @"--to")
    {
        Description = @"end of period, unix ts or now-relative, check from, defaults to now",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.DeploymentStatsOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.DeploymentStatsOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"deploy-stats", @"Deploy Stats");
                        command.Arguments.Add(DeployId);
                        command.Options.Add(From);
                        command.Options.Add(To);
                        command.Options.Add(XiApiKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var deployId = parseResult.GetRequiredValue(DeployId);
                        var from = parseResult.GetRequiredValue(From);
                        var to = parseResult.GetValue(To);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DeployStatsAsync(
                                    deployId: deployId,
                                    from: from,
                                    to: to,
                                    xiApiKey: xiApiKey,
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