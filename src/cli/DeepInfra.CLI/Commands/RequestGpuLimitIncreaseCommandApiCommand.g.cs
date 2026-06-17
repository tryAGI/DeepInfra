#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class RequestGpuLimitIncreaseCommandApiCommand
{
    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<string> GpuType { get; } = new(
        name: @"--gpu-type")
    {
        Description = @"",
        Required = true,
    };

    private static Option<int> RequestedLimit { get; } = new(
        name: @"--requested-limit")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Reason { get; } = new(
        name: @"--reason")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"request-gpu-limit-increase", @"Request Gpu Limit Increase");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(GpuType);
                        command.Options.Add(RequestedLimit);
                        command.Options.Add(Reason);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var gpuType = parseResult.GetRequiredValue(GpuType);
                        var requestedLimit = parseResult.GetRequiredValue(RequestedLimit);
                        var reason = parseResult.GetRequiredValue(Reason);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.RequestGpuLimitIncreaseAsync(
                                    xiApiKey: xiApiKey,
                                    gpuType: gpuType,
                                    requestedLimit: requestedLimit,
                                    reason: reason,
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