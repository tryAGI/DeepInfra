#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record CompletionMultiModalDataOptionSet(
    Option<global::System.Collections.Generic.IList<string>?> Image)
{
    public static CompletionMultiModalDataOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CompletionMultiModalDataOptionSet(
                        Image: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}image")
                {
                    Description = @"List of images as base64 data URIs (e.g. 'data:image/png;base64,...'). Each image must correspond to a placeholder token in the prompt.",
                }
        );
    }
}