#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ResponsesOpenaiResponsesNotFound2CommandApiCommand
{
    private static Argument<string> ResponseId { get; } = new(
        name: @"response-id")
    {
        Description = @"",
    };

    private static Option<string?> XDeepinfraServiceTier { get; } = new(
        name: @"--x-deepinfra-service-tier")
    {
        Description = @"Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.",
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"openai-responses-not-found2", @"Openai Responses Not Found");
                        command.Arguments.Add(ResponseId);
                        command.Options.Add(XDeepinfraServiceTier);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var responseId = parseResult.GetRequiredValue(ResponseId);
                        var xDeepinfraServiceTier = parseResult.GetValue(XDeepinfraServiceTier);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Responses.OpenaiResponsesNotFound2Async(
                                    responseId: responseId,
                                    xDeepinfraServiceTier: xDeepinfraServiceTier,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::DeepInfra.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}