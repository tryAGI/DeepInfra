#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record OpenAITextToSpeechInOptionSet(
    Option<string> Model,
                     Option<string> InputOption,
                     Option<string?> Voice,
                     Option<global::DeepInfra.TtsResponseFormat?> ResponseFormat,
                     Option<double?> Speed)
{
    public static OpenAITextToSpeechInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new OpenAITextToSpeechInOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"model name",
                    Required = true,
                },
                InputOption: new Option<string>($"--{normalizedPrefix}input")
                {
                    Description = @"Text to convert to speech",
                    Required = true,
                },
                Voice: new Option<string?>($"--{normalizedPrefix}voice")
                {
                    Description = @"Preset voices to use for the speech.",
                },
                ResponseFormat: new Option<global::DeepInfra.TtsResponseFormat?>($"--{normalizedPrefix}response-format")
                {
                    Description = @"response format for the speech",
                },
                Speed: new Option<double?>($"--{normalizedPrefix}speed")
                {
                    Description = @"speed of the speech",
                }
        );
    }
}