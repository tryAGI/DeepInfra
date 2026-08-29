#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record VideoGenerationInOptionSet(
    Option<string> Model,
                     Option<string> Prompt,
                     Option<string?> NegativePrompt,
                     Option<string?> AspectRatio,
                     Option<string?> Size,
                     Option<int?> Seconds,
                     Option<int?> Seed,
                     Option<string?> Style,
                     Option<string?> ImageUrl)
{
    public static VideoGenerationInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new VideoGenerationInOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"",
                    Required = true,
                },
                Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"",
                    Required = true,
                },
                NegativePrompt: new Option<string?>($"--{normalizedPrefix}negative-prompt")
                {
                    Description = @"",
                },
                AspectRatio: new Option<string?>($"--{normalizedPrefix}aspect-ratio")
                {
                    Description = @"",
                },
                Size: new Option<string?>($"--{normalizedPrefix}size")
                {
                    Description = @"",
                },
                Seconds: new Option<int?>($"--{normalizedPrefix}seconds")
                {
                    Description = @"",
                },
                Seed: new Option<int?>($"--{normalizedPrefix}seed")
                {
                    Description = @"",
                },
                Style: new Option<string?>($"--{normalizedPrefix}style")
                {
                    Description = @"",
                },
                ImageUrl: new Option<string?>($"--{normalizedPrefix}image-url")
                {
                    Description = @"First-frame image for image-to-video (i2v): an http(s) URL or a data: URI. Omit for text-to-video.",
                }
        );
    }
}