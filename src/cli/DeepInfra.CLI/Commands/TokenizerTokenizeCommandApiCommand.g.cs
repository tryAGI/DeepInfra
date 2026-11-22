#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class TokenizerTokenizeCommandApiCommand
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
        Description = @"model name",
        Required = true,
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"text to tokenize (completion form)",
    };

    private static Option<global::System.Collections.Generic.IList<object>?> Messages { get; } = new(
        name: @"--messages")
    {
        Description = @"chat messages to tokenize (chat form)",
    };

    private static Option<bool?> AddSpecialTokens { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--add-special-tokens",
        description: @"add the tokenizer's special tokens");

    private static Option<bool?> AddGenerationPrompt { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--add-generation-prompt",
        description: @"append the assistant turn header (chat form)");

    private static Option<bool?> ContinueFinalMessage { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--continue-final-message",
        description: @"leave the final message open for continuation (chat form)");

    private static Option<string?> ChatTemplate { get; } = new(
        name: @"--chat-template")
    {
        Description = @"chat template override (chat form; the engine may refuse it)",
    };

    private static Option<object?> ChatTemplateKwargs { get; } = new(
        name: @"--chat-template-kwargs")
    {
        Description = @"extra variables for the chat template (chat form)",
    };

    private static Option<global::System.Collections.Generic.IList<object>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"tool definitions to render (chat form)",
    };

    private static Option<bool?> ReturnTokenStrs { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--return-token-strs",
        description: @"also return the per-token strings (vLLM)");
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

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.TokenizeOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.TokenizeOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"tokenize", @"Tokenize");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(Model);
                        command.Options.Add(Prompt);
                        command.Options.Add(Messages);
                        command.Options.Add(AddSpecialTokens);
                        command.Options.Add(AddGenerationPrompt);
                        command.Options.Add(ContinueFinalMessage);
                        command.Options.Add(ChatTemplate);
                        command.Options.Add(ChatTemplateKwargs);
                        command.Options.Add(Tools);
                        command.Options.Add(ReturnTokenStrs);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.TokenizeIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var model = parseResult.GetRequiredValue(Model);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var messages = CliRuntime.WasSpecified(parseResult, Messages) ? parseResult.GetValue(Messages) : (__requestBase is { } __MessagesBaseValue ? __MessagesBaseValue.Messages : default);
                        var addSpecialTokens = CliRuntime.WasSpecified(parseResult, AddSpecialTokens) ? parseResult.GetValue(AddSpecialTokens) : (__requestBase is { } __AddSpecialTokensBaseValue ? __AddSpecialTokensBaseValue.AddSpecialTokens : default);
                        var addGenerationPrompt = CliRuntime.WasSpecified(parseResult, AddGenerationPrompt) ? parseResult.GetValue(AddGenerationPrompt) : (__requestBase is { } __AddGenerationPromptBaseValue ? __AddGenerationPromptBaseValue.AddGenerationPrompt : default);
                        var continueFinalMessage = CliRuntime.WasSpecified(parseResult, ContinueFinalMessage) ? parseResult.GetValue(ContinueFinalMessage) : (__requestBase is { } __ContinueFinalMessageBaseValue ? __ContinueFinalMessageBaseValue.ContinueFinalMessage : default);
                        var chatTemplate = CliRuntime.WasSpecified(parseResult, ChatTemplate) ? parseResult.GetValue(ChatTemplate) : (__requestBase is { } __ChatTemplateBaseValue ? __ChatTemplateBaseValue.ChatTemplate : default);
                        var chatTemplateKwargs = CliRuntime.WasSpecified(parseResult, ChatTemplateKwargs) ? parseResult.GetValue(ChatTemplateKwargs) : (__requestBase is { } __ChatTemplateKwargsBaseValue ? __ChatTemplateKwargsBaseValue.ChatTemplateKwargs : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var returnTokenStrs = CliRuntime.WasSpecified(parseResult, ReturnTokenStrs) ? parseResult.GetValue(ReturnTokenStrs) : (__requestBase is { } __ReturnTokenStrsBaseValue ? __ReturnTokenStrsBaseValue.ReturnTokenStrs : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Tokenizer.TokenizeAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    model: model,
                                    prompt: prompt,
                                    messages: messages,
                                    addSpecialTokens: addSpecialTokens,
                                    addGenerationPrompt: addGenerationPrompt,
                                    continueFinalMessage: continueFinalMessage,
                                    chatTemplate: chatTemplate,
                                    chatTemplateKwargs: chatTemplateKwargs,
                                    tools: tools,
                                    returnTokenStrs: returnTokenStrs,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::DeepInfra.SourceGenerationContext.Default,
                                        @"Tokens",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::DeepInfra.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}