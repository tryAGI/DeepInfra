#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ResponsesOpenaiResponsesCommandApiCommand
{
    private static Option<string?> XDeepinfraSource { get; } = new(
        name: @"--x-deepinfra-source")
    {
        Description = @"",
    };

    private static Option<string?> XDeepinfraServiceTier { get; } = new(
        name: @"--x-deepinfra-service-tier")
    {
        Description = @"Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.",
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
        Description = @"",
        Required = true,
    };

    private static Option<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> Instructions { get; } = new(
        name: @"--instructions")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, object>>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"",
    };

    private static Option<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesInToolChoiceEnum?, global::DeepInfra.ResponsesFunctionToolChoice, object, object>?> ToolChoice { get; } = new(
        name: @"--tool-choice")
    {
        Description = @"",
    };

    private static Option<global::DeepInfra.ResponsesTextConfig?> Text { get; } = new(
        name: @"--text")
    {
        Description = @"",
    };

    private static Option<global::DeepInfra.ResponsesReasoningConfig?> Reasoning { get; } = new(
        name: @"--reasoning")
    {
        Description = @"",
    };

    private static Option<int?> MaxOutputTokens { get; } = new(
        name: @"--max-output-tokens")
    {
        Description = @"",
    };

    private static Option<int?> MaxToolCalls { get; } = new(
        name: @"--max-tool-calls")
    {
        Description = @"",
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"",
    };

    private static Option<double?> TopP { get; } = new(
        name: @"--top-p")
    {
        Description = @"",
    };

    private static Option<int?> TopLogprobs { get; } = new(
        name: @"--top-logprobs")
    {
        Description = @"",
    };

    private static Option<object?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };

    private static Option<bool?> ParallelToolCalls { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--parallel-tool-calls",
        description: @"");

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"");

    private static Option<string?> User { get; } = new(
        name: @"--user")
    {
        Description = @"",
    };

    private static Option<bool?> Store { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--store",
        description: @"");

    private static Option<string?> PreviousResponseId { get; } = new(
        name: @"--previous-response-id")
    {
        Description = @"",
    };

    private static Option<bool?> Background { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--background",
        description: @"");

    private static Option<global::System.Collections.Generic.IList<string>?> Include { get; } = new(
        name: @"--include")
    {
        Description = @"",
    };

    private static Option<global::DeepInfra.ResponsesInTruncation?> Truncation { get; } = new(
        name: @"--truncation")
    {
        Description = @"",
    };

    private static Option<object?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
    };

    private static Option<object?> Conversation { get; } = new(
        name: @"--conversation")
    {
        Description = @"",
    };

    private static Option<double?> MinP { get; } = new(
        name: @"--min-p")
    {
        Description = @"",
    };

    private static Option<int?> TopK { get; } = new(
        name: @"--top-k")
    {
        Description = @"",
    };

    private static Option<double?> RepetitionPenalty { get; } = new(
        name: @"--repetition-penalty")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<int>?> StopTokenIds { get; } = new(
        name: @"--stop-token-ids")
    {
        Description = @"",
    };

    private static Option<object?> ChatTemplateKwargs { get; } = new(
        name: @"--chat-template-kwargs")
    {
        Description = @"",
    };

    private static Option<bool?> ContinueFinalMessage { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--continue-final-message",
        description: @"");

    private static Option<bool?> IgnoreEos { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--ignore-eos",
        description: @"");

    private static Option<string?> PromptCacheKey { get; } = new(
        name: @"--prompt-cache-key")
    {
        Description = @"",
    };

    private static Option<global::DeepInfra.PromptCacheOptions?> PromptCacheOptions { get; } = new(
        name: @"--prompt-cache-options")
    {
        Description = @"",
    };
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"openai-responses", @"Openai Responses");
                        command.Options.Add(XDeepinfraSource);
                        command.Options.Add(XDeepinfraServiceTier);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(ServiceTier);
                        command.Options.Add(FailFast);
                        command.Options.Add(Models);
                        command.Options.Add(Model);
                        command.Options.Add(InputOption);
                        command.Options.Add(Instructions);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(Text);
                        command.Options.Add(Reasoning);
                        command.Options.Add(MaxOutputTokens);
                        command.Options.Add(MaxToolCalls);
                        command.Options.Add(Temperature);
                        command.Options.Add(TopP);
                        command.Options.Add(TopLogprobs);
                        command.Options.Add(Metadata);
                        command.Options.Add(ParallelToolCalls);
                        command.Options.Add(Stream);
                        command.Options.Add(User);
                        command.Options.Add(Store);
                        command.Options.Add(PreviousResponseId);
                        command.Options.Add(Background);
                        command.Options.Add(Include);
                        command.Options.Add(Truncation);
                        command.Options.Add(Prompt);
                        command.Options.Add(Conversation);
                        command.Options.Add(MinP);
                        command.Options.Add(TopK);
                        command.Options.Add(RepetitionPenalty);
                        command.Options.Add(StopTokenIds);
                        command.Options.Add(ChatTemplateKwargs);
                        command.Options.Add(ContinueFinalMessage);
                        command.Options.Add(IgnoreEos);
                        command.Options.Add(PromptCacheKey);
                        command.Options.Add(PromptCacheOptions);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.ResponsesIn>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xDeepinfraSource = parseResult.GetValue(XDeepinfraSource);
                        var xDeepinfraServiceTier = parseResult.GetValue(XDeepinfraServiceTier);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var serviceTier = CliRuntime.WasSpecified(parseResult, ServiceTier) ? parseResult.GetValue(ServiceTier) : (__requestBase is { } __ServiceTierBaseValue ? __ServiceTierBaseValue.ServiceTier : default);
                        var failFast = CliRuntime.WasSpecified(parseResult, FailFast) ? parseResult.GetValue(FailFast) : (__requestBase is { } __FailFastBaseValue ? __FailFastBaseValue.FailFast : default);
                        var models = CliRuntime.WasSpecified(parseResult, Models) ? parseResult.GetValue(Models) : (__requestBase is { } __ModelsBaseValue ? __ModelsBaseValue.Models : default);
                        var model = parseResult.GetRequiredValue(Model);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var instructions = CliRuntime.WasSpecified(parseResult, Instructions) ? parseResult.GetValue(Instructions) : (__requestBase is { } __InstructionsBaseValue ? __InstructionsBaseValue.Instructions : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : (__requestBase is { } __ToolChoiceBaseValue ? __ToolChoiceBaseValue.ToolChoice : default);
                        var text = CliRuntime.WasSpecified(parseResult, Text) ? parseResult.GetValue(Text) : (__requestBase is { } __TextBaseValue ? __TextBaseValue.Text : default);
                        var reasoning = CliRuntime.WasSpecified(parseResult, Reasoning) ? parseResult.GetValue(Reasoning) : (__requestBase is { } __ReasoningBaseValue ? __ReasoningBaseValue.Reasoning : default);
                        var maxOutputTokens = CliRuntime.WasSpecified(parseResult, MaxOutputTokens) ? parseResult.GetValue(MaxOutputTokens) : (__requestBase is { } __MaxOutputTokensBaseValue ? __MaxOutputTokensBaseValue.MaxOutputTokens : default);
                        var maxToolCalls = CliRuntime.WasSpecified(parseResult, MaxToolCalls) ? parseResult.GetValue(MaxToolCalls) : (__requestBase is { } __MaxToolCallsBaseValue ? __MaxToolCallsBaseValue.MaxToolCalls : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, TopP) ? parseResult.GetValue(TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var topLogprobs = CliRuntime.WasSpecified(parseResult, TopLogprobs) ? parseResult.GetValue(TopLogprobs) : (__requestBase is { } __TopLogprobsBaseValue ? __TopLogprobsBaseValue.TopLogprobs : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var parallelToolCalls = CliRuntime.WasSpecified(parseResult, ParallelToolCalls) ? parseResult.GetValue(ParallelToolCalls) : (__requestBase is { } __ParallelToolCallsBaseValue ? __ParallelToolCallsBaseValue.ParallelToolCalls : default);
                        var stream = CliRuntime.WasSpecified(parseResult, Stream) ? parseResult.GetValue(Stream) : (__requestBase is { } __StreamBaseValue ? __StreamBaseValue.Stream : default);
                        var user = CliRuntime.WasSpecified(parseResult, User) ? parseResult.GetValue(User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                        var store = CliRuntime.WasSpecified(parseResult, Store) ? parseResult.GetValue(Store) : (__requestBase is { } __StoreBaseValue ? __StoreBaseValue.Store : default);
                        var previousResponseId = CliRuntime.WasSpecified(parseResult, PreviousResponseId) ? parseResult.GetValue(PreviousResponseId) : (__requestBase is { } __PreviousResponseIdBaseValue ? __PreviousResponseIdBaseValue.PreviousResponseId : default);
                        var background = CliRuntime.WasSpecified(parseResult, Background) ? parseResult.GetValue(Background) : (__requestBase is { } __BackgroundBaseValue ? __BackgroundBaseValue.Background : default);
                        var include = CliRuntime.WasSpecified(parseResult, Include) ? parseResult.GetValue(Include) : (__requestBase is { } __IncludeBaseValue ? __IncludeBaseValue.Include : default);
                        var truncation = CliRuntime.WasSpecified(parseResult, Truncation) ? parseResult.GetValue(Truncation) : (__requestBase is { } __TruncationBaseValue ? __TruncationBaseValue.Truncation : default);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var conversation = CliRuntime.WasSpecified(parseResult, Conversation) ? parseResult.GetValue(Conversation) : (__requestBase is { } __ConversationBaseValue ? __ConversationBaseValue.Conversation : default);
                        var minP = CliRuntime.WasSpecified(parseResult, MinP) ? parseResult.GetValue(MinP) : (__requestBase is { } __MinPBaseValue ? __MinPBaseValue.MinP : default);
                        var topK = CliRuntime.WasSpecified(parseResult, TopK) ? parseResult.GetValue(TopK) : (__requestBase is { } __TopKBaseValue ? __TopKBaseValue.TopK : default);
                        var repetitionPenalty = CliRuntime.WasSpecified(parseResult, RepetitionPenalty) ? parseResult.GetValue(RepetitionPenalty) : (__requestBase is { } __RepetitionPenaltyBaseValue ? __RepetitionPenaltyBaseValue.RepetitionPenalty : default);
                        var stopTokenIds = CliRuntime.WasSpecified(parseResult, StopTokenIds) ? parseResult.GetValue(StopTokenIds) : (__requestBase is { } __StopTokenIdsBaseValue ? __StopTokenIdsBaseValue.StopTokenIds : default);
                        var chatTemplateKwargs = CliRuntime.WasSpecified(parseResult, ChatTemplateKwargs) ? parseResult.GetValue(ChatTemplateKwargs) : (__requestBase is { } __ChatTemplateKwargsBaseValue ? __ChatTemplateKwargsBaseValue.ChatTemplateKwargs : default);
                        var continueFinalMessage = CliRuntime.WasSpecified(parseResult, ContinueFinalMessage) ? parseResult.GetValue(ContinueFinalMessage) : (__requestBase is { } __ContinueFinalMessageBaseValue ? __ContinueFinalMessageBaseValue.ContinueFinalMessage : default);
                        var ignoreEos = CliRuntime.WasSpecified(parseResult, IgnoreEos) ? parseResult.GetValue(IgnoreEos) : (__requestBase is { } __IgnoreEosBaseValue ? __IgnoreEosBaseValue.IgnoreEos : default);
                        var promptCacheKey = CliRuntime.WasSpecified(parseResult, PromptCacheKey) ? parseResult.GetValue(PromptCacheKey) : (__requestBase is { } __PromptCacheKeyBaseValue ? __PromptCacheKeyBaseValue.PromptCacheKey : default);
                        var promptCacheOptions = CliRuntime.WasSpecified(parseResult, PromptCacheOptions) ? parseResult.GetValue(PromptCacheOptions) : (__requestBase is { } __PromptCacheOptionsBaseValue ? __PromptCacheOptionsBaseValue.PromptCacheOptions : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Responses.OpenaiResponsesAsync(
                                    xDeepinfraSource: xDeepinfraSource,
                                    xDeepinfraServiceTier: xDeepinfraServiceTier,
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    serviceTier: serviceTier,
                                    failFast: failFast,
                                    models: models,
                                    model: model,
                                    input: input,
                                    instructions: instructions,
                                    tools: tools,
                                    toolChoice: toolChoice,
                                    text: text,
                                    reasoning: reasoning,
                                    maxOutputTokens: maxOutputTokens,
                                    maxToolCalls: maxToolCalls,
                                    temperature: temperature,
                                    topP: topP,
                                    topLogprobs: topLogprobs,
                                    metadata: metadata,
                                    parallelToolCalls: parallelToolCalls,
                                    stream: stream,
                                    user: user,
                                    store: store,
                                    previousResponseId: previousResponseId,
                                    background: background,
                                    include: include,
                                    truncation: truncation,
                                    prompt: prompt,
                                    conversation: conversation,
                                    minP: minP,
                                    topK: topK,
                                    repetitionPenalty: repetitionPenalty,
                                    stopTokenIds: stopTokenIds,
                                    chatTemplateKwargs: chatTemplateKwargs,
                                    continueFinalMessage: continueFinalMessage,
                                    ignoreEos: ignoreEos,
                                    promptCacheKey: promptCacheKey,
                                    promptCacheOptions: promptCacheOptions,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::DeepInfra.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}