#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ChatCompletionsAnthropicMessagesCommandApiCommand
{
    private static Option<string?> AnthropicVersion { get; } = new(
        name: @"--anthropic-version")
    {
        Description = @"",
    };

    private static Option<string?> AnthropicBeta { get; } = new(
        name: @"--anthropic-beta")
    {
        Description = @"",
    };

    private static Option<string?> XDeepinfraSource { get; } = new(
        name: @"--x-deepinfra-source")
    {
        Description = @"",
    };

    private static Option<string?> XDeepinfraServiceTier { get; } = new(
        name: @"--x-deepinfra-service-tier")
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
        Description = @"",
        Required = true,
    };

    private static Option<int?> MaxTokens { get; } = new(
        name: @"--max-tokens")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<object>> Messages { get; } = new(
        name: @"--messages")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>?> System { get; } = new(
        name: @"--system")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> StopSequences { get; } = new(
        name: @"--stop-sequences")
    {
        Description = @"",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"");

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

    private static Option<int?> TopK { get; } = new(
        name: @"--top-k")
    {
        Description = @"",
    };

    private static Option<object?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"",
    };

    private static Option<object?> ToolChoice { get; } = new(
        name: @"--tool-choice")
    {
        Description = @"",
    };

    private static Option<string?> PromptCacheKey { get; } = new(
        name: @"--prompt-cache-key")
    {
        Description = @"",
    };
    private static readonly AnthropicThinkingConfigOptionSet ThinkingOptions = AnthropicThinkingConfigOptionSet.Create(@"thinking");
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
        var command = new Command(@"anthropic-messages", @"Anthropic Messages");
                        command.Options.Add(AnthropicVersion);
                        command.Options.Add(AnthropicBeta);
                        command.Options.Add(XDeepinfraSource);
                        command.Options.Add(XDeepinfraServiceTier);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(ServiceTier);
                        command.Options.Add(FailFast);
                        command.Options.Add(Models);
                        command.Options.Add(Model);
                        command.Options.Add(MaxTokens);
                        command.Options.Add(Messages);
                        command.Options.Add(System);
                        command.Options.Add(StopSequences);
                        command.Options.Add(Stream);
                        command.Options.Add(Temperature);
                        command.Options.Add(TopP);
                        command.Options.Add(TopK);
                        command.Options.Add(Metadata);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(PromptCacheKey);                        command.Options.Add(ThinkingOptions.BudgetTokens);
                        command.Options.Add(ThinkingOptions.Enabled);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.AnthropicMessagesIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var anthropicVersion = parseResult.GetValue(AnthropicVersion);
                        var anthropicBeta = parseResult.GetValue(AnthropicBeta);
                        var xDeepinfraSource = parseResult.GetValue(XDeepinfraSource);
                        var xDeepinfraServiceTier = parseResult.GetValue(XDeepinfraServiceTier);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var serviceTier = CliRuntime.WasSpecified(parseResult, ServiceTier) ? parseResult.GetValue(ServiceTier) : (__requestBase is { } __ServiceTierBaseValue ? __ServiceTierBaseValue.ServiceTier : default);
                        var failFast = CliRuntime.WasSpecified(parseResult, FailFast) ? parseResult.GetValue(FailFast) : (__requestBase is { } __FailFastBaseValue ? __FailFastBaseValue.FailFast : default);
                        var models = CliRuntime.WasSpecified(parseResult, Models) ? parseResult.GetValue(Models) : (__requestBase is { } __ModelsBaseValue ? __ModelsBaseValue.Models : default);
                        var model = parseResult.GetRequiredValue(Model);
                        var maxTokens = CliRuntime.WasSpecified(parseResult, MaxTokens) ? parseResult.GetValue(MaxTokens) : (__requestBase is { } __MaxTokensBaseValue ? __MaxTokensBaseValue.MaxTokens : default);
                        var messages = parseResult.GetRequiredValue(Messages);
                        var system = CliRuntime.WasSpecified(parseResult, System) ? parseResult.GetValue(System) : (__requestBase is { } __SystemBaseValue ? __SystemBaseValue.System : default);
                        var stopSequences = CliRuntime.WasSpecified(parseResult, StopSequences) ? parseResult.GetValue(StopSequences) : (__requestBase is { } __StopSequencesBaseValue ? __StopSequencesBaseValue.StopSequences : default);
                        var stream = CliRuntime.WasSpecified(parseResult, Stream) ? parseResult.GetValue(Stream) : (__requestBase is { } __StreamBaseValue ? __StreamBaseValue.Stream : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var topP = CliRuntime.WasSpecified(parseResult, TopP) ? parseResult.GetValue(TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var topK = CliRuntime.WasSpecified(parseResult, TopK) ? parseResult.GetValue(TopK) : (__requestBase is { } __TopKBaseValue ? __TopKBaseValue.TopK : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : (__requestBase is { } __ToolChoiceBaseValue ? __ToolChoiceBaseValue.ToolChoice : default);
                        var promptCacheKey = CliRuntime.WasSpecified(parseResult, PromptCacheKey) ? parseResult.GetValue(PromptCacheKey) : (__requestBase is { } __PromptCacheKeyBaseValue ? __PromptCacheKeyBaseValue.PromptCacheKey : default);

                        var __ThinkingBase = __requestBase is { } __ThinkingBaseValue ? __ThinkingBaseValue.Thinking : default;                        var thinkingBudgetTokens = CliRuntime.WasSpecified(parseResult, ThinkingOptions.BudgetTokens) ? parseResult.GetValue(ThinkingOptions.BudgetTokens) : (__ThinkingBase is { } __ThinkingbudgetTokensBaseValue ? __ThinkingbudgetTokensBaseValue.BudgetTokens : default);
                        var thinkingEnabled = CliRuntime.WasSpecified(parseResult, ThinkingOptions.Enabled) ? parseResult.GetValue(ThinkingOptions.Enabled) : (__ThinkingBase is { } __ThinkingenabledBaseValue ? __ThinkingenabledBaseValue.Enabled : default);
                        var __ThinkingSpecified = CliRuntime.WasSpecified(parseResult, ThinkingOptions.BudgetTokens) || CliRuntime.WasSpecified(parseResult, ThinkingOptions.Enabled);
                        var thinking =
                            __ThinkingSpecified || __ThinkingBase is not null
                                ? new global::DeepInfra.AnthropicThinkingConfig
                                {
	                                BudgetTokens = thinkingBudgetTokens,
                                Enabled = thinkingEnabled,

                                }
                                : __ThinkingBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ChatCompletions.AnthropicMessagesAsync(
                                    anthropicVersion: anthropicVersion,
                                    anthropicBeta: anthropicBeta,
                                    xDeepinfraSource: xDeepinfraSource,
                                    xDeepinfraServiceTier: xDeepinfraServiceTier,
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    serviceTier: serviceTier,
                                    failFast: failFast,
                                    models: models,
                                    model: model,
                                    maxTokens: maxTokens,
                                    messages: messages,
                                    system: system,
                                    stopSequences: stopSequences,
                                    stream: stream,
                                    temperature: temperature,
                                    topP: topP,
                                    topK: topK,
                                    metadata: metadata,
                                    tools: tools,
                                    toolChoice: toolChoice,
                                    promptCacheKey: promptCacheKey,
                                    thinking: thinking,
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