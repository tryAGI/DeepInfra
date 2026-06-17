#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record OpenAIImagesEditsInOptionSet(
    Option<string> Model,
                     Option<int?> N,
                     Option<string?> Size,
                     Option<string?> User,
                     Option<string> Imagename,
                     Option<string> Prompt,
                     Option<string?> Maskname)
{
    public static OpenAIImagesEditsInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new OpenAIImagesEditsInOptionSet(
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
                    Description = @"Input image bytes for editing task",
                    Required = true,
                },
                Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"A text description of the desired image edits.",
                    Required = true,
                },
                Maskname: new Option<string?>($"--{normalizedPrefix}maskname")
                {
                    Description = @"An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where image should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as image.",
                }
        );
    }
}