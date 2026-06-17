#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record OpenAIImagesVariationsInOptionSet(
    Option<string> Model,
                     Option<int?> N,
                     Option<string?> Size,
                     Option<string?> User,
                     Option<string> Imagename)
{
    public static OpenAIImagesVariationsInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new OpenAIImagesVariationsInOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"The model to use.",
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
                Imagename: new Option<string>($"--{normalizedPrefix}imagename")
                {
                    Description = @"Input image bytes for variation task",
                    Required = true,
                }
        );
    }
}