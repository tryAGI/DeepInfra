#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class LogsQueryCommandApiCommand
{
    private static Option<string> DeployId { get; } = new(
        name: @"--deploy-id")
    {
        Description = @"the deploy id to get the logs from",
        Required = true,
    };

    private static Option<string?> From { get; } = new(
        name: @"--from")
    {
        Description = @"start of period, in fractional seconds since unix epoch (inclusive)",
    };

    private static Option<string?> To { get; } = new(
        name: @"--to")
    {
        Description = @"end of period, in fractional seconds since unix epoch (exclusive)",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"how many items to return at most (default 100, in [1, 1000])",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.LogQueryOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.LogQueryOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"logs-query", @"Logs Query
Query inference logs.
* Without timestamps (from/to) returns last `limit` messages (in last month).
* With `from` only, returns first `limit` messages after `from` (inclusive).
* With `to` only, returns last `limit` messages before `to` (inclusive).
* With both `from` and `to`, return the first `limit` messages after `from`, but not later than `to`.
* `from` and `to` should be no more than a month apart.");
                        command.Options.Add(DeployId);
                        command.Options.Add(From);
                        command.Options.Add(To);
                        command.Options.Add(Limit);
                        command.Options.Add(XiApiKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var deployId = parseResult.GetRequiredValue(DeployId);
                        var from = parseResult.GetValue(From);
                        var to = parseResult.GetValue(To);
                        var limit = parseResult.GetValue(Limit);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LogsQueryAsync(
                                    deployId: deployId,
                                    from: from,
                                    to: to,
                                    limit: limit,
                                    xiApiKey: xiApiKey,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::DeepInfra.SourceGenerationContext.Default,
                                        @"Entries",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::DeepInfra.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}