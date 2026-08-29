#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class TextCompletionsOpenaiCompletionsCommandApiCommand
{
    private static Option<string?> XDeepinfraSource { get; } = new(
        name: @"--x-deepinfra-source")
    {
        Description = @"",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<string?> XApiKey { get; } = new(
        name: @"--x-api-key")
    {
        Description = @"",
    };

    private static Option<global::DeepInfra.ServiceTier?> ServiceTier { get; } = new(
        name: @"--service-tier")
    {
        Description = @"The service tier used for processing the request. 'priority' processes the request with higher priority (premium rate); 'flex' processes it at lower priority for a discount, served only when spare capacity exists and may be retried/timed out under load. Both apply only to models that support the respective tier. For compatibility, 'auto' is treated as 'priority' and 'standard_only' as 'default'.",
    };

    private static Option<bool?> FailFast { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--fail-fast",
        description: @"If true, the request is rejected immediately with HTTP 429 when the model has no spare capacity, instead of waiting in the queue. Opt-in; the default (false) keeps standard queueing behavior.");

    private static Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
        name: @"--models")
    {
        Description = @"Ordered list of up to 4 fallback models. The request is attempted on each model in order: when a model rejects it for lack of capacity (HTTP 429 model-busy / flex no-capacity), the next model is tried server-side. The first model that accepts serves the request; the response's model field and billing reflect that model, at that model's pricing. Models before the last are attempted without queueing (as if fail_fast were set); the last model honors the request's own fail_fast value. When models is set, the model field is ignored. Entries must be plain model names (no deploy_id:, custom_hostport, or :revision specifiers); duplicate entries are ignored, keeping the first occurrence.",
    };

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"model name",
        Required = true,
    };

    private static Option<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"input prompt - a single string is currently supported",
        Required = true,
    };

    private static Option<int?> MaxTokens { get; } = new(
        name: @"--max-tokens")
    {
        Description = @"The maximum number of tokens to generate in the completion.

The total length of input tokens and generated tokens is limited by the model's context length.If explicitly set to None it will be the model's max context length minus input length or 65536, whichever is smaller.",
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic",
    };

    private static Option<double?> TopP { get; } = new(
        name: @"--top-p")
    {
        Description = @"An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.",
    };

    private static Option<double?> MinP { get; } = new(
        name: @"--min-p")
    {
        Description = @"Float that represents the minimum probability for a token to be considered, relative to the probability of the most likely token. Must be in [0, 1]. Set to 0 to disable this.",
    };

    private static Option<int?> TopK { get; } = new(
        name: @"--top-k")
    {
        Description = @"Sample from the best k (number of) tokens. 0 means off",
    };

    private static Option<int?> N { get; } = new(
        name: @"--n")
    {
        Description = @"number of sequences to return",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"whether to stream the output via SSE or return the full response");

    private static Option<int?> Logprobs { get; } = new(
        name: @"--logprobs")
    {
        Description = @"return top tokens and their log-probabilities",
    };

    private static Option<bool?> Echo { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--echo",
        description: @"return prompt as part of the respons");

    private static Option<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?> Stop { get; } = new(
        name: @"--stop")
    {
        Description = @"up to 16 sequences where the API will stop generating further tokens",
    };

    private static Option<double?> PresencePenalty { get; } = new(
        name: @"--presence-penalty")
    {
        Description = @"Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.",
    };

    private static Option<double?> FrequencyPenalty { get; } = new(
        name: @"--frequency-penalty")
    {
        Description = @"Positive values penalize new tokens based on how many times they appear in the text so far, increasing the model's likelihood to talk about new topics.",
    };

    private static Option<global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"The format of the response. Currently, only json is supported.",
    };

    private static Option<double?> RepetitionPenalty { get; } = new(
        name: @"--repetition-penalty")
    {
        Description = @"Alternative penalty for repetition, but multiplicative instead of additive (> 1 penalize, < 1 encourage)",
    };

    private static Option<string?> User { get; } = new(
        name: @"--user")
    {
        Description = @"A unique identifier representing your end-user, which can help  monitor and detect abuse. Avoid sending us any identifying information. We recommend hashing user identifiers.",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Seed for random number generator. If not provided, a random seed is used. Determinism is not guaranteed.",
    };

    private static Option<global::System.Collections.Generic.IList<int>?> StopTokenIds { get; } = new(
        name: @"--stop-token-ids")
    {
        Description = @"Up to 16 token IDs where the API will stop generating further tokens. Merged with the model's built-in stop tokens. Intended for private deployments.",
    };

    private static Option<bool?> ReturnTokensAsTokenIds { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--return-tokens-as-token-ids",
        description: @"return tokens as token ids");

    private static Option<string?> PromptCacheKey { get; } = new(
        name: @"--prompt-cache-key")
    {
        Description = @"A key to identify prompt cache for reuse across requests. If provided, the prompt will be cached and can be reused in subsequent requests with the same key.",
    };

    private static Option<global::DeepInfra.PromptCacheOptions?> PromptCacheOptions { get; } = new(
        name: @"--prompt-cache-options")
    {
        Description = @"Prompt cache options for this request's prefix, e.g. {""ttl"": ""1h""}.",
    };

    private static Option<global::DeepInfra.CompletionMultiModalData?> Data { get; } = new(
        name: @"--data")
    {
        Description = @"Optional multi-modal data to pass alongside the prompt. Only supported for a small number of non-chat-native vision models. Images must be base64 data URIs (e.g. 'data:image/png;base64,...').",
    };

    private static Option<bool?> IgnoreEos { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--ignore-eos",
        description: @"Keep generating until max_tokens instead of stopping at the end-of-sequence token. Only honoured on models tagged with the allow_ignore_eos feature flag; ignored otherwise. Intended for benchmarking, where a fixed output length is needed.");
    private static readonly StreamOptionsOptionSet StreamOptionsOptions = StreamOptionsOptionSet.Create(@"stream");
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"openai-completions", @"Openai Completions");
                        command.Options.Add(XDeepinfraSource);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(ServiceTier);
                        command.Options.Add(FailFast);
                        command.Options.Add(Models);
                        command.Options.Add(Model);
                        command.Options.Add(Prompt);
                        command.Options.Add(MaxTokens);
                        command.Options.Add(Temperature);
                        command.Options.Add(TopP);
                        command.Options.Add(MinP);
                        command.Options.Add(TopK);
                        command.Options.Add(N);
                        command.Options.Add(Stream);
                        command.Options.Add(Logprobs);
                        command.Options.Add(Echo);
                        command.Options.Add(Stop);
                        command.Options.Add(PresencePenalty);
                        command.Options.Add(FrequencyPenalty);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(RepetitionPenalty);
                        command.Options.Add(User);
                        command.Options.Add(Seed);
                        command.Options.Add(StopTokenIds);
                        command.Options.Add(ReturnTokensAsTokenIds);
                        command.Options.Add(PromptCacheKey);
                        command.Options.Add(PromptCacheOptions);
                        command.Options.Add(Data);
                        command.Options.Add(IgnoreEos);                        command.Options.Add(StreamOptionsOptions.IncludeUsage);
                        command.Options.Add(StreamOptionsOptions.ContinuousUsageStats);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.OpenAICompletionsIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xDeepinfraSource = parseResult.GetValue(XDeepinfraSource);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var serviceTier = CliRuntime.WasSpecified(parseResult, ServiceTier) ? parseResult.GetValue(ServiceTier) : (__requestBase is { } __ServiceTierBaseValue ? __ServiceTierBaseValue.ServiceTier : default);
                        var failFast = CliRuntime.WasSpecified(parseResult, FailFast) ? parseResult.GetValue(FailFast) : (__requestBase is { } __FailFastBaseValue ? __FailFastBaseValue.FailFast : default);
                        var models = CliRuntime.WasSpecified(parseResult, Models) ? parseResult.GetValue(Models) : (__requestBase is { } __ModelsBaseValue ? __ModelsBaseValue.Models : default);
                        var model = parseResult.GetRequiredValue(Model);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var maxTokens = CliRuntime.WasSpecified(parseResult, MaxTokens) ? parseResult.GetValue(MaxTokens) : (__requestBase is { } __MaxTokensBaseValue ? __MaxTokensBaseValue.MaxTokens : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, TopP) ? parseResult.GetValue(TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var minP = CliRuntime.WasSpecified(parseResult, MinP) ? parseResult.GetValue(MinP) : (__requestBase is { } __MinPBaseValue ? __MinPBaseValue.MinP : default);
                        var topK = CliRuntime.WasSpecified(parseResult, TopK) ? parseResult.GetValue(TopK) : (__requestBase is { } __TopKBaseValue ? __TopKBaseValue.TopK : default);
                        var n = CliRuntime.WasSpecified(parseResult, N) ? parseResult.GetValue(N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var stream = CliRuntime.WasSpecified(parseResult, Stream) ? parseResult.GetValue(Stream) : (__requestBase is { } __StreamBaseValue ? __StreamBaseValue.Stream : default);
                        var logprobs = CliRuntime.WasSpecified(parseResult, Logprobs) ? parseResult.GetValue(Logprobs) : (__requestBase is { } __LogprobsBaseValue ? __LogprobsBaseValue.Logprobs : default);
                        var echo = CliRuntime.WasSpecified(parseResult, Echo) ? parseResult.GetValue(Echo) : (__requestBase is { } __EchoBaseValue ? __EchoBaseValue.Echo : default);
                        var stop = CliRuntime.WasSpecified(parseResult, Stop) ? parseResult.GetValue(Stop) : (__requestBase is { } __StopBaseValue ? __StopBaseValue.Stop : default);
                        var presencePenalty = CliRuntime.WasSpecified(parseResult, PresencePenalty) ? parseResult.GetValue(PresencePenalty) : (__requestBase is { } __PresencePenaltyBaseValue ? __PresencePenaltyBaseValue.PresencePenalty : default);
                        var frequencyPenalty = CliRuntime.WasSpecified(parseResult, FrequencyPenalty) ? parseResult.GetValue(FrequencyPenalty) : (__requestBase is { } __FrequencyPenaltyBaseValue ? __FrequencyPenaltyBaseValue.FrequencyPenalty : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var repetitionPenalty = CliRuntime.WasSpecified(parseResult, RepetitionPenalty) ? parseResult.GetValue(RepetitionPenalty) : (__requestBase is { } __RepetitionPenaltyBaseValue ? __RepetitionPenaltyBaseValue.RepetitionPenalty : default);
                        var user = CliRuntime.WasSpecified(parseResult, User) ? parseResult.GetValue(User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var stopTokenIds = CliRuntime.WasSpecified(parseResult, StopTokenIds) ? parseResult.GetValue(StopTokenIds) : (__requestBase is { } __StopTokenIdsBaseValue ? __StopTokenIdsBaseValue.StopTokenIds : default);
                        var returnTokensAsTokenIds = CliRuntime.WasSpecified(parseResult, ReturnTokensAsTokenIds) ? parseResult.GetValue(ReturnTokensAsTokenIds) : (__requestBase is { } __ReturnTokensAsTokenIdsBaseValue ? __ReturnTokensAsTokenIdsBaseValue.ReturnTokensAsTokenIds : default);
                        var promptCacheKey = CliRuntime.WasSpecified(parseResult, PromptCacheKey) ? parseResult.GetValue(PromptCacheKey) : (__requestBase is { } __PromptCacheKeyBaseValue ? __PromptCacheKeyBaseValue.PromptCacheKey : default);
                        var promptCacheOptions = CliRuntime.WasSpecified(parseResult, PromptCacheOptions) ? parseResult.GetValue(PromptCacheOptions) : (__requestBase is { } __PromptCacheOptionsBaseValue ? __PromptCacheOptionsBaseValue.PromptCacheOptions : default);
                        var data = CliRuntime.WasSpecified(parseResult, Data) ? parseResult.GetValue(Data) : (__requestBase is { } __DataBaseValue ? __DataBaseValue.Data : default);
                        var ignoreEos = CliRuntime.WasSpecified(parseResult, IgnoreEos) ? parseResult.GetValue(IgnoreEos) : (__requestBase is { } __IgnoreEosBaseValue ? __IgnoreEosBaseValue.IgnoreEos : default);

                        var __StreamOptionsBase = __requestBase is { } __StreamOptionsBaseValue ? __StreamOptionsBaseValue.StreamOptions : default;                        var streamOptionsIncludeUsage = CliRuntime.WasSpecified(parseResult, StreamOptionsOptions.IncludeUsage) ? parseResult.GetValue(StreamOptionsOptions.IncludeUsage) : (__StreamOptionsBase is { } __StreamOptionsincludeUsageBaseValue ? __StreamOptionsincludeUsageBaseValue.IncludeUsage : default);
                        var streamOptionsContinuousUsageStats = CliRuntime.WasSpecified(parseResult, StreamOptionsOptions.ContinuousUsageStats) ? parseResult.GetValue(StreamOptionsOptions.ContinuousUsageStats) : (__StreamOptionsBase is { } __StreamOptionscontinuousUsageStatsBaseValue ? __StreamOptionscontinuousUsageStatsBaseValue.ContinuousUsageStats : default);
                        var __StreamOptionsSpecified = CliRuntime.WasSpecified(parseResult, StreamOptionsOptions.IncludeUsage) || CliRuntime.WasSpecified(parseResult, StreamOptionsOptions.ContinuousUsageStats);
                        var streamOptions =
                            __StreamOptionsSpecified || __StreamOptionsBase is not null
                                ? new global::DeepInfra.StreamOptions
                                {
	                                IncludeUsage = streamOptionsIncludeUsage,
                                ContinuousUsageStats = streamOptionsContinuousUsageStats,

                                }
                                : __StreamOptionsBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TextCompletions.OpenaiCompletionsAsync(
                                    xDeepinfraSource: xDeepinfraSource,
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    serviceTier: serviceTier,
                                    failFast: failFast,
                                    models: models,
                                    model: model,
                                    prompt: prompt,
                                    maxTokens: maxTokens,
                                    temperature: temperature,
                                    topP: topP,
                                    minP: minP,
                                    topK: topK,
                                    n: n,
                                    stream: stream,
                                    logprobs: logprobs,
                                    echo: echo,
                                    stop: stop,
                                    presencePenalty: presencePenalty,
                                    frequencyPenalty: frequencyPenalty,
                                    responseFormat: responseFormat,
                                    repetitionPenalty: repetitionPenalty,
                                    user: user,
                                    seed: seed,
                                    stopTokenIds: stopTokenIds,
                                    returnTokensAsTokenIds: returnTokensAsTokenIds,
                                    promptCacheKey: promptCacheKey,
                                    promptCacheOptions: promptCacheOptions,
                                    data: data,
                                    ignoreEos: ignoreEos,
                                    streamOptions: streamOptions,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::DeepInfra.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}