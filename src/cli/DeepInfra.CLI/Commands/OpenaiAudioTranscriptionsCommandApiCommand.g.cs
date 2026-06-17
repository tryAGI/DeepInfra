#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class OpenaiAudioTranscriptionsCommandApiCommand
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

    private static Option<byte[]> File { get; } = new(
        name: @"--file")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"",
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
    };

    private static Option<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"",
    };

    private static Option<double?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>?> TimestampGranularities { get; } = new(
        name: @"--timestamp-granularities")
    {
        Description = @"",
    };
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
        var command = new Command(@"openai-audio-transcriptions", @"Openai Audio Transcriptions");
                        command.Options.Add(XDeepinfraSource);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(Model);
                        command.Options.Add(Language);
                        command.Options.Add(Prompt);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(Temperature);
                        command.Options.Add(TimestampGranularities);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPost>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xDeepinfraSource = parseResult.GetValue(XDeepinfraSource);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var file = parseResult.GetRequiredValue(File);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var model = parseResult.GetRequiredValue(Model);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var timestampGranularities = CliRuntime.WasSpecified(parseResult, TimestampGranularities) ? parseResult.GetValue(TimestampGranularities) : (__requestBase is { } __TimestampGranularitiesBaseValue ? __TimestampGranularitiesBaseValue.TimestampGranularities : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenaiAudioTranscriptionsAsync(
                                    xDeepinfraSource: xDeepinfraSource,
                                    xiApiKey: xiApiKey,
                                    file: file,
                                    filename: filename,
                                    model: model,
                                    language: language,
                                    prompt: prompt,
                                    responseFormat: responseFormat,
                                    temperature: temperature,
                                    timestampGranularities: timestampGranularities,
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