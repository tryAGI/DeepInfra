#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class OpenaiAudioSpeech2CommandApiCommand
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

    private static Option<global::DeepInfra.ServiceTier?> ServiceTier { get; } = new(
        name: @"--service-tier")
    {
        Description = @"The service tier used for processing the request. When set to 'priority', the request will be processed with higher priority (only applies to models that support it).",
    };

    private static Option<object?> ExtraBody { get; } = new(
        name: @"--extra-body")
    {
        Description = @"Extra body parameters for the model.",
    };
    private static readonly OpenAITextToSpeechInOptionSet OpenAITextToSpeechInOptionSetOptions = OpenAITextToSpeechInOptionSet.Create();
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


    public static Command Create()
    {
        var command = new Command(@"openai-audio-speech2", @"Openai Audio Speech");
                        command.Options.Add(XDeepinfraSource);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(ServiceTier);
                        command.Options.Add(ExtraBody);                        command.Options.Add(OpenAITextToSpeechInOptionSetOptions.Model);
                        command.Options.Add(OpenAITextToSpeechInOptionSetOptions.InputOption);
                        command.Options.Add(OpenAITextToSpeechInOptionSetOptions.Voice);
                        command.Options.Add(OpenAITextToSpeechInOptionSetOptions.ResponseFormat);
                        command.Options.Add(OpenAITextToSpeechInOptionSetOptions.Speed);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.OpenAITextToSpeechIn>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xDeepinfraSource = parseResult.GetValue(XDeepinfraSource);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var serviceTier = CliRuntime.WasSpecified(parseResult, ServiceTier) ? parseResult.GetValue(ServiceTier) : (__requestBase is { } __ServiceTierBaseValue ? __ServiceTierBaseValue.ServiceTier : default);
                        var extraBody = CliRuntime.WasSpecified(parseResult, ExtraBody) ? parseResult.GetValue(ExtraBody) : (__requestBase is { } __ExtraBodyBaseValue ? __ExtraBodyBaseValue.ExtraBody : default);                        var model = parseResult.GetRequiredValue(OpenAITextToSpeechInOptionSetOptions.Model);
                        var input = parseResult.GetRequiredValue(OpenAITextToSpeechInOptionSetOptions.InputOption);
                        var voice = CliRuntime.WasSpecified(parseResult, OpenAITextToSpeechInOptionSetOptions.Voice) ? parseResult.GetValue(OpenAITextToSpeechInOptionSetOptions.Voice) : (__requestBase is { } __VoiceBaseValue ? __VoiceBaseValue.Voice : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, OpenAITextToSpeechInOptionSetOptions.ResponseFormat) ? parseResult.GetValue(OpenAITextToSpeechInOptionSetOptions.ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var speed = CliRuntime.WasSpecified(parseResult, OpenAITextToSpeechInOptionSetOptions.Speed) ? parseResult.GetValue(OpenAITextToSpeechInOptionSetOptions.Speed) : (__requestBase is { } __SpeedBaseValue ? __SpeedBaseValue.Speed : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenaiAudioSpeech2Async(
                                    xDeepinfraSource: xDeepinfraSource,
                                    xiApiKey: xiApiKey,
                                    serviceTier: serviceTier,
                                    extraBody: extraBody,
                                    model: model,
                                    input: input,
                                    voice: voice,
                                    responseFormat: responseFormat,
                                    speed: speed,
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