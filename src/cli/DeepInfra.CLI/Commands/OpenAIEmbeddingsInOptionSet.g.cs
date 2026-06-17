#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record OpenAIEmbeddingsInOptionSet(
    Option<string> Model,
                     Option<global::DeepInfra.OpenAIEmbeddingsInEncodingFormat?> EncodingFormat,
                     Option<int?> Dimensions)
{
    public static OpenAIEmbeddingsInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new OpenAIEmbeddingsInOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"model name",
                    Required = true,
                },
                EncodingFormat: new Option<global::DeepInfra.OpenAIEmbeddingsInEncodingFormat?>($"--{normalizedPrefix}encoding-format")
                {
                    Description = @"format used when encoding",
                },
                Dimensions: new Option<int?>($"--{normalizedPrefix}dimensions")
                {
                    Description = @"The number of dimensions in the embedding. If not provided, the model's default will be used.If provided bigger than model's default, the embedding will be padded with zeros.",
                }
        );
    }
}