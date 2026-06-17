#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record OpenAIChatCompletionsInOptionSet(
    Option<string> Model,
                     Option<bool?> Stream,
                     Option<double?> Temperature,
                     Option<double?> TopP,
                     Option<double?> MinP,
                     Option<int?> TopK,
                     Option<int?> MaxTokens,
                     Option<int?> N,
                     Option<double?> PresencePenalty,
                     Option<double?> FrequencyPenalty,
                     Option<double?> RepetitionPenalty,
                     Option<string?> User,
                     Option<int?> Seed,
                     Option<bool?> Logprobs,
                     Option<string?> PromptCacheKey)
{
    public static OpenAIChatCompletionsInOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new OpenAIChatCompletionsInOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"model name",
                    Required = true,
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"whether to stream the output via SSE or return the full response"),
                Temperature: new Option<double?>($"--{normalizedPrefix}temperature")
                {
                    Description = @"What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic",
                },
                TopP: new Option<double?>($"--{normalizedPrefix}top-p")
                {
                    Description = @"An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.",
                },
                MinP: new Option<double?>($"--{normalizedPrefix}min-p")
                {
                    Description = @"Float that represents the minimum probability for a token to be considered, relative to the probability of the most likely token. Must be in [0, 1]. Set to 0 to disable this.",
                },
                TopK: new Option<int?>($"--{normalizedPrefix}top-k")
                {
                    Description = @"Sample from the best k (number of) tokens. 0 means off",
                },
                MaxTokens: new Option<int?>($"--{normalizedPrefix}max-tokens")
                {
                    Description = @"The maximum number of tokens to generate in the chat completion.

The total length of input tokens and generated tokens is limited by the model's context length. If explicitly set to None it will be the model's max context length minus input length or 16384, whichever is smaller.",
                },
                N: new Option<int?>($"--{normalizedPrefix}n")
                {
                    Description = @"number of sequences to return",
                },
                PresencePenalty: new Option<double?>($"--{normalizedPrefix}presence-penalty")
                {
                    Description = @"Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.",
                },
                FrequencyPenalty: new Option<double?>($"--{normalizedPrefix}frequency-penalty")
                {
                    Description = @"Positive values penalize new tokens based on how many times they appear in the text so far, increasing the model's likelihood to talk about new topics.",
                },
                RepetitionPenalty: new Option<double?>($"--{normalizedPrefix}repetition-penalty")
                {
                    Description = @"Alternative penalty for repetition, but multiplicative instead of additive (> 1 penalize, < 1 encourage)",
                },
                User: new Option<string?>($"--{normalizedPrefix}user")
                {
                    Description = @"A unique identifier representing your end-user, which can help monitor and detect abuse. Avoid sending us any identifying information. We recommend hashing user identifiers.",
                },
                Seed: new Option<int?>($"--{normalizedPrefix}seed")
                {
                    Description = @"Seed for random number generator. If not provided, a random seed is used. Determinism is not guaranteed.",
                },
                Logprobs: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}logprobs", description: @"Whether to return log probabilities of the output tokens or not.If true, returns the log probabilities of each output token returned in the `content` of `message`."),
                PromptCacheKey: new Option<string?>($"--{normalizedPrefix}prompt-cache-key")
                {
                    Description = @"A key to identify prompt cache for reuse across requests. If provided, the prompt will be cached and can be reused in subsequent requests with the same key.",
                }
        );
    }
}