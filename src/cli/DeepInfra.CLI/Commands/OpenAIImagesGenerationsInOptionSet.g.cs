#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record OpenAIImagesGenerationsInOptionSet(
    Option<string> Model,
                     Option<int?> N,
                     Option<string?> Size,
                     Option<string?> User,
                     Option<string> Prompt,
                     Option<string?> Quality,
                     Option<string?> Style)
{
    public static OpenAIImagesGenerationsInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new OpenAIImagesGenerationsInOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"The model to use for image generation.",
                    Required = true,
                },
                N: new Option<int?>($"--{normalizedPrefix}n")
                {
                    Description = @"The number of images to generate.",
                },
                Size: new Option<string?>($"--{normalizedPrefix}size")
                {
                    Description = @"The size of the generated images. Available sizes depend on the model.",
                },
                User: new Option<string?>($"--{normalizedPrefix}user")
                {
                    Description = @"A unique identifier representing your end-user, which can help to monitor and detect abuse.",
                },
                Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"A text description of desired image(s).",
                    Required = true,
                },
                Quality: new Option<string?>($"--{normalizedPrefix}quality")
                {
                    Description = @"The quality of the image that will be generated.",
                },
                Style: new Option<string?>($"--{normalizedPrefix}style")
                {
                    Description = @"The style of the generated images.",
                }
        );
    }
}