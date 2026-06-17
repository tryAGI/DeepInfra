#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class UpdateVoiceCommandApiCommand
{
    private static Argument<string> VoiceId { get; } = new(
        name: @"voice-id")
    {
        Description = @"",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<string> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.Voice value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.Voice value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-voice", @"Update Voice");
                        command.Arguments.Add(VoiceId);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var voiceId = parseResult.GetRequiredValue(VoiceId);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var description = parseResult.GetRequiredValue(DescriptionOption);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UpdateVoiceAsync(
                                    voiceId: voiceId,
                                    xiApiKey: xiApiKey,
                                    name: name,
                                    description: description,
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