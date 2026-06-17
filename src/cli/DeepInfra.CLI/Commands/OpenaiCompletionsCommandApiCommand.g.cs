#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class OpenaiCompletionsCommandApiCommand
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

    private static Option<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"input prompt - a single string is currently supported",
        Required = true,
    };

    private static Option<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?> Stop { get; } = new(
        name: @"--stop")
    {
        Description = @"up to 16 sequences where the API will stop generating further tokens",
    };

    private static Option<global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"The format of the response. Currently, only json is supported.",
    };

    private static Option<global::System.Collections.Generic.IList<int>?> StopTokenIds { get; } = new(
        name: @"--stop-token-ids")
    {
        Description = @"List of token IDs that will stop generation when encountered",
    };
    private static readonly OpenAICompletionsInOptionSet OpenAICompletionsInOptionSetOptions = OpenAICompletionsInOptionSet.Create();

    private static readonly StreamOptionsOptionSet StreamOptionsOptions = StreamOptionsOptionSet.Create(@"stream");

    private static readonly CompletionMultiModalDataOptionSet DataOptions = CompletionMultiModalDataOptionSet.Create(@"data");
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
                        command.Options.Add(Prompt);
                        command.Options.Add(Stop);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(StopTokenIds);                        command.Options.Add(OpenAICompletionsInOptionSetOptions.Model);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.MaxTokens);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.Temperature);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.TopP);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.MinP);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.TopK);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.N);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.Stream);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.Logprobs);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.Echo);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.PresencePenalty);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.FrequencyPenalty);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.RepetitionPenalty);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.User);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.Seed);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.ReturnTokensAsTokenIds);
                        command.Options.Add(OpenAICompletionsInOptionSetOptions.PromptCacheKey);                        command.Options.Add(StreamOptionsOptions.IncludeUsage);
                        command.Options.Add(StreamOptionsOptions.ContinuousUsageStats);                        command.Options.Add(DataOptions.Image);
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
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var stop = CliRuntime.WasSpecified(parseResult, Stop) ? parseResult.GetValue(Stop) : (__requestBase is { } __StopBaseValue ? __StopBaseValue.Stop : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var stopTokenIds = CliRuntime.WasSpecified(parseResult, StopTokenIds) ? parseResult.GetValue(StopTokenIds) : (__requestBase is { } __StopTokenIdsBaseValue ? __StopTokenIdsBaseValue.StopTokenIds : default);                        var model = parseResult.GetRequiredValue(OpenAICompletionsInOptionSetOptions.Model);
                        var maxTokens = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.MaxTokens) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.MaxTokens) : (__requestBase is { } __MaxTokensBaseValue ? __MaxTokensBaseValue.MaxTokens : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.Temperature) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.TopP) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var minP = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.MinP) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.MinP) : (__requestBase is { } __MinPBaseValue ? __MinPBaseValue.MinP : default);
                        var topK = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.TopK) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.TopK) : (__requestBase is { } __TopKBaseValue ? __TopKBaseValue.TopK : default);
                        var n = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.N) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var stream = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.Stream) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.Stream) : (__requestBase is { } __StreamBaseValue ? __StreamBaseValue.Stream : default);
                        var logprobs = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.Logprobs) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.Logprobs) : (__requestBase is { } __LogprobsBaseValue ? __LogprobsBaseValue.Logprobs : default);
                        var echo = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.Echo) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.Echo) : (__requestBase is { } __EchoBaseValue ? __EchoBaseValue.Echo : default);
                        var presencePenalty = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.PresencePenalty) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.PresencePenalty) : (__requestBase is { } __PresencePenaltyBaseValue ? __PresencePenaltyBaseValue.PresencePenalty : default);
                        var frequencyPenalty = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.FrequencyPenalty) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.FrequencyPenalty) : (__requestBase is { } __FrequencyPenaltyBaseValue ? __FrequencyPenaltyBaseValue.FrequencyPenalty : default);
                        var repetitionPenalty = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.RepetitionPenalty) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.RepetitionPenalty) : (__requestBase is { } __RepetitionPenaltyBaseValue ? __RepetitionPenaltyBaseValue.RepetitionPenalty : default);
                        var user = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.User) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                        var seed = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.Seed) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var returnTokensAsTokenIds = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.ReturnTokensAsTokenIds) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.ReturnTokensAsTokenIds) : (__requestBase is { } __ReturnTokensAsTokenIdsBaseValue ? __ReturnTokensAsTokenIdsBaseValue.ReturnTokensAsTokenIds : default);
                        var promptCacheKey = CliRuntime.WasSpecified(parseResult, OpenAICompletionsInOptionSetOptions.PromptCacheKey) ? parseResult.GetValue(OpenAICompletionsInOptionSetOptions.PromptCacheKey) : (__requestBase is { } __PromptCacheKeyBaseValue ? __PromptCacheKeyBaseValue.PromptCacheKey : default);

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

                        var __DataBase = __requestBase is { } __DataBaseValue ? __DataBaseValue.Data : default;                        var dataImage = CliRuntime.WasSpecified(parseResult, DataOptions.Image) ? parseResult.GetValue(DataOptions.Image) : (__DataBase is { } __DataimageBaseValue ? __DataimageBaseValue.Image : default);
                        var __DataSpecified = CliRuntime.WasSpecified(parseResult, DataOptions.Image);
                        var data =
                            __DataSpecified || __DataBase is not null
                                ? new global::DeepInfra.CompletionMultiModalData
                                {
	                                Image = dataImage,

                                }
                                : __DataBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenaiCompletionsAsync(
                                    xDeepinfraSource: xDeepinfraSource,
                                    xiApiKey: xiApiKey,
                                    prompt: prompt,
                                    stop: stop,
                                    responseFormat: responseFormat,
                                    stopTokenIds: stopTokenIds,
                                    model: model,
                                    maxTokens: maxTokens,
                                    temperature: temperature,
                                    topP: topP,
                                    minP: minP,
                                    topK: topK,
                                    n: n,
                                    stream: stream,
                                    logprobs: logprobs,
                                    echo: echo,
                                    presencePenalty: presencePenalty,
                                    frequencyPenalty: frequencyPenalty,
                                    repetitionPenalty: repetitionPenalty,
                                    user: user,
                                    seed: seed,
                                    returnTokensAsTokenIds: returnTokensAsTokenIds,
                                    promptCacheKey: promptCacheKey,
                                    streamOptions: streamOptions,
                                    data: data,
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