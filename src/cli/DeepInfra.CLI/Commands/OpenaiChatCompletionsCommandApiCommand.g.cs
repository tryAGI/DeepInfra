#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class OpenaiChatCompletionsCommandApiCommand
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

    private static Option<global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>>> Messages { get; } = new(
        name: @"--messages")
    {
        Description = @"conversation messages: (user,assistant,tool)*,user including one system message anywhere",
        Required = true,
    };

    private static Option<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?> Stop { get; } = new(
        name: @"--stop")
    {
        Description = @"up to 16 sequences where the API will stop generating further tokens",
    };

    private static Option<global::System.Collections.Generic.IList<global::DeepInfra.ChatTools>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"A list of tools the model may call. Currently, only functions are supported as a tool.",
    };

    private static Option<global::DeepInfra.AnyOf<string, global::DeepInfra.ChatTools, object>?> ToolChoice { get; } = new(
        name: @"--tool-choice")
    {
        Description = @"Controls which (if any) function is called by the model. none means the model will not call a function and instead generates a message. auto means the model can pick between generating a message or calling a function. required means the model must call a function. defined tool means the model must call that specific tool. none is the default when no functions are present. auto is the default if functions are present.",
    };

    private static Option<global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"The format of the response. Currently, only json is supported.",
    };

    private static Option<global::DeepInfra.OpenAIChatCompletionsInReasoningEffort2?> ReasoningEffort { get; } = new(
        name: @"--reasoning-effort")
    {
        Description = @"Constrains effort on reasoning for reasoning models. Currently supported values are none, low, medium, and high. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Setting to none disables reasoning entirely if the model supports.",
    };

    private static Option<object?> ChatTemplateKwargs { get; } = new(
        name: @"--chat-template-kwargs")
    {
        Description = @"Chat template kwargs.",
    };
    private static readonly OpenAIChatCompletionsInOptionSet OpenAIChatCompletionsInOptionSetOptions = OpenAIChatCompletionsInOptionSet.Create();

    private static readonly StreamOptionsOptionSet StreamOptionsOptions = StreamOptionsOptionSet.Create(@"stream");

    private static readonly ChatReasoningSettingsOptionSet ReasoningOptions = ChatReasoningSettingsOptionSet.Create(@"reasoning");
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
        var command = new Command(@"openai-chat-completions", @"Openai Chat Completions");
                        command.Options.Add(XDeepinfraSource);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(Messages);
                        command.Options.Add(Stop);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(ReasoningEffort);
                        command.Options.Add(ChatTemplateKwargs);                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.Model);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.Stream);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.Temperature);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.TopP);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.MinP);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.TopK);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.MaxTokens);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.N);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.PresencePenalty);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.FrequencyPenalty);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.RepetitionPenalty);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.User);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.Seed);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.Logprobs);
                        command.Options.Add(OpenAIChatCompletionsInOptionSetOptions.PromptCacheKey);                        command.Options.Add(StreamOptionsOptions.IncludeUsage);
                        command.Options.Add(StreamOptionsOptions.ContinuousUsageStats);                        command.Options.Add(ReasoningOptions.Enabled);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.OpenAIChatCompletionsIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xDeepinfraSource = parseResult.GetValue(XDeepinfraSource);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var messages = parseResult.GetRequiredValue(Messages);
                        var stop = CliRuntime.WasSpecified(parseResult, Stop) ? parseResult.GetValue(Stop) : (__requestBase is { } __StopBaseValue ? __StopBaseValue.Stop : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : (__requestBase is { } __ToolChoiceBaseValue ? __ToolChoiceBaseValue.ToolChoice : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var reasoningEffort = CliRuntime.WasSpecified(parseResult, ReasoningEffort) ? parseResult.GetValue(ReasoningEffort) : (__requestBase is { } __ReasoningEffortBaseValue ? __ReasoningEffortBaseValue.ReasoningEffort : default);
                        var chatTemplateKwargs = CliRuntime.WasSpecified(parseResult, ChatTemplateKwargs) ? parseResult.GetValue(ChatTemplateKwargs) : (__requestBase is { } __ChatTemplateKwargsBaseValue ? __ChatTemplateKwargsBaseValue.ChatTemplateKwargs : default);                        var model = parseResult.GetRequiredValue(OpenAIChatCompletionsInOptionSetOptions.Model);
                        var stream = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.Stream) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.Stream) : (__requestBase is { } __StreamBaseValue ? __StreamBaseValue.Stream : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.Temperature) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.TopP) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var minP = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.MinP) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.MinP) : (__requestBase is { } __MinPBaseValue ? __MinPBaseValue.MinP : default);
                        var topK = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.TopK) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.TopK) : (__requestBase is { } __TopKBaseValue ? __TopKBaseValue.TopK : default);
                        var maxTokens = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.MaxTokens) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.MaxTokens) : (__requestBase is { } __MaxTokensBaseValue ? __MaxTokensBaseValue.MaxTokens : default);
                        var n = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.N) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var presencePenalty = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.PresencePenalty) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.PresencePenalty) : (__requestBase is { } __PresencePenaltyBaseValue ? __PresencePenaltyBaseValue.PresencePenalty : default);
                        var frequencyPenalty = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.FrequencyPenalty) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.FrequencyPenalty) : (__requestBase is { } __FrequencyPenaltyBaseValue ? __FrequencyPenaltyBaseValue.FrequencyPenalty : default);
                        var repetitionPenalty = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.RepetitionPenalty) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.RepetitionPenalty) : (__requestBase is { } __RepetitionPenaltyBaseValue ? __RepetitionPenaltyBaseValue.RepetitionPenalty : default);
                        var user = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.User) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                        var seed = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.Seed) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var logprobs = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.Logprobs) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.Logprobs) : (__requestBase is { } __LogprobsBaseValue ? __LogprobsBaseValue.Logprobs : default);
                        var promptCacheKey = CliRuntime.WasSpecified(parseResult, OpenAIChatCompletionsInOptionSetOptions.PromptCacheKey) ? parseResult.GetValue(OpenAIChatCompletionsInOptionSetOptions.PromptCacheKey) : (__requestBase is { } __PromptCacheKeyBaseValue ? __PromptCacheKeyBaseValue.PromptCacheKey : default);

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

                        var __ReasoningBase = __requestBase is { } __ReasoningBaseValue ? __ReasoningBaseValue.Reasoning : default;                        var reasoningEnabled = CliRuntime.WasSpecified(parseResult, ReasoningOptions.Enabled) ? parseResult.GetValue(ReasoningOptions.Enabled) : (__ReasoningBase is { } __ReasoningenabledBaseValue ? __ReasoningenabledBaseValue.Enabled : default);
                        var __ReasoningSpecified = CliRuntime.WasSpecified(parseResult, ReasoningOptions.Enabled);
                        var reasoning =
                            __ReasoningSpecified || __ReasoningBase is not null
                                ? new global::DeepInfra.ChatReasoningSettings
                                {
	                                Enabled = reasoningEnabled,

                                }
                                : __ReasoningBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenaiChatCompletionsAsync(
                                    xDeepinfraSource: xDeepinfraSource,
                                    xiApiKey: xiApiKey,
                                    messages: messages,
                                    stop: stop,
                                    tools: tools,
                                    toolChoice: toolChoice,
                                    responseFormat: responseFormat,
                                    reasoningEffort: reasoningEffort,
                                    chatTemplateKwargs: chatTemplateKwargs,
                                    model: model,
                                    stream: stream,
                                    temperature: temperature,
                                    topP: topP,
                                    minP: minP,
                                    topK: topK,
                                    maxTokens: maxTokens,
                                    n: n,
                                    presencePenalty: presencePenalty,
                                    frequencyPenalty: frequencyPenalty,
                                    repetitionPenalty: repetitionPenalty,
                                    user: user,
                                    seed: seed,
                                    logprobs: logprobs,
                                    promptCacheKey: promptCacheKey,
                                    streamOptions: streamOptions,
                                    reasoning: reasoning,
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