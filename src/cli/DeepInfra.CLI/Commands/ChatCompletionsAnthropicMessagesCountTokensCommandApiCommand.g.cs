#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ChatCompletionsAnthropicMessagesCountTokensCommandApiCommand
{
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

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
        Required = true,
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
        var command = new Command(@"anthropic-messages-count-tokens", @"Anthropic Messages Count Tokens");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(Model);
                        command.Options.Add(Messages);
                        command.Options.Add(System);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolChoice);                        command.Options.Add(ThinkingOptions.BudgetTokens);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.AnthropicTokenCountRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var model = parseResult.GetRequiredValue(Model);
                        var messages = parseResult.GetRequiredValue(Messages);
                        var system = CliRuntime.WasSpecified(parseResult, System) ? parseResult.GetValue(System) : (__requestBase is { } __SystemBaseValue ? __SystemBaseValue.System : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : (__requestBase is { } __ToolChoiceBaseValue ? __ToolChoiceBaseValue.ToolChoice : default);

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


                                var response = await client.ChatCompletions.AnthropicMessagesCountTokensAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    model: model,
                                    messages: messages,
                                    system: system,
                                    tools: tools,
                                    toolChoice: toolChoice,
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