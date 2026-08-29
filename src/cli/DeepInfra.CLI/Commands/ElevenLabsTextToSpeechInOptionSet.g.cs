#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record ElevenLabsTextToSpeechInOptionSet(
    Option<string> Text,
                     Option<string?> ModelId,
                     Option<global::DeepInfra.TtsResponseFormat?> OutputFormat,
                     Option<string?> LanguageCode)
{
    public static ElevenLabsTextToSpeechInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ElevenLabsTextToSpeechInOptionSet(
                        Text: new Option<string>($"--{normalizedPrefix}text")
                {
                    Description = @"Text to convert to speech",
                    Required = true,
                },
                ModelId: new Option<string?>($"--{normalizedPrefix}model-id")
                {
                    Description = @"Model ID to use for the conversion",
                },
                OutputFormat: new Option<global::DeepInfra.TtsResponseFormat?>($"--{normalizedPrefix}output-format")
                {
                    Description = @"Output format for the speech",
                },
                LanguageCode: new Option<string?>($"--{normalizedPrefix}language-code")
                {
                    Description = @"ISO 639-1, 2-letter language code",
                }
        );
    }
}