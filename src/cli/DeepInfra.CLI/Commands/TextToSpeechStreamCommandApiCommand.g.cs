#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class TextToSpeechStreamCommandApiCommand
{
    private static Argument<string> VoiceId { get; } = new(
        name: @"voice-id")
    {
        Description = @"",
    };

    private static Option<string?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };
    private static readonly ElevenLabsTextToSpeechInOptionSet ElevenLabsTextToSpeechInOptionSetOptions = ElevenLabsTextToSpeechInOptionSet.Create();
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
        var command = new Command(@"text-to-speech-stream", @"Text To Speech Stream");
                        command.Arguments.Add(VoiceId);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(XiApiKey);                        command.Options.Add(ElevenLabsTextToSpeechInOptionSetOptions.Text);
                        command.Options.Add(ElevenLabsTextToSpeechInOptionSetOptions.ModelId);
                        command.Options.Add(ElevenLabsTextToSpeechInOptionSetOptions.OutputFormat);
                        command.Options.Add(ElevenLabsTextToSpeechInOptionSetOptions.LanguageCode);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.ElevenLabsTextToSpeechIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var voiceId = parseResult.GetRequiredValue(VoiceId);
                        var outputFormat = parseResult.GetValue(OutputFormat);
                        var xiApiKey = parseResult.GetValue(XiApiKey);                        var text = parseResult.GetRequiredValue(ElevenLabsTextToSpeechInOptionSetOptions.Text);
                        var modelId = CliRuntime.WasSpecified(parseResult, ElevenLabsTextToSpeechInOptionSetOptions.ModelId) ? parseResult.GetValue(ElevenLabsTextToSpeechInOptionSetOptions.ModelId) : (__requestBase is { } __ModelIdBaseValue ? __ModelIdBaseValue.ModelId : default);
                        var requestOutputFormat = CliRuntime.WasSpecified(parseResult, ElevenLabsTextToSpeechInOptionSetOptions.OutputFormat) ? parseResult.GetValue(ElevenLabsTextToSpeechInOptionSetOptions.OutputFormat) : (__requestBase is { } __RequestOutputFormatBaseValue ? __RequestOutputFormatBaseValue.OutputFormat : default);
                        var languageCode = CliRuntime.WasSpecified(parseResult, ElevenLabsTextToSpeechInOptionSetOptions.LanguageCode) ? parseResult.GetValue(ElevenLabsTextToSpeechInOptionSetOptions.LanguageCode) : (__requestBase is { } __LanguageCodeBaseValue ? __LanguageCodeBaseValue.LanguageCode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TextToSpeechStreamAsync(
                                    voiceId: voiceId,
                                    outputFormat: outputFormat,
                                    xiApiKey: xiApiKey,
                                    text: text,
                                    modelId: modelId,
                                    requestOutputFormat: requestOutputFormat,
                                    languageCode: languageCode,
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