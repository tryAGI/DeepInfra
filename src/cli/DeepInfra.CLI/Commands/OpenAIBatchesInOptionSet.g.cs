#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record OpenAIBatchesInOptionSet(
    Option<string> InputFileId,
                     Option<global::DeepInfra.OpenAIBatchesInEndpoint> Endpoint,
                     Option<string> CompletionWindow)
{
    public static OpenAIBatchesInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new OpenAIBatchesInOptionSet(
                        InputFileId: new Option<string>($"--{normalizedPrefix}input-file-id")
                {
                    Description = @"The ID of an uploaded file that contains requests for the new batch.",
                    Required = true,
                },
                Endpoint: new Option<global::DeepInfra.OpenAIBatchesInEndpoint>($"--{normalizedPrefix}endpoint")
                {
                    Description = @"The endpoint to be used for all requests in the batch. Currently /v1/chat/completions, /v1/completions are supported.",
                    Required = true,
                },
                CompletionWindow: new Option<string>($"--{normalizedPrefix}completion-window")
                {
                    Description = @"The time frame within which the batch should be processed. Currently only 24h is supported.",
                    DefaultValueFactory = _ => "24h",
                }
        );
    }
}