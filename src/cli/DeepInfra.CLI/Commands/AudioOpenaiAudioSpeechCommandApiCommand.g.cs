#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class AudioOpenaiAudioSpeechCommandApiCommand
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

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"model name",
        Required = true,
    };

    private static Option<string> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Text to convert to speech",
        Required = true,
    };

    private static Option<string?> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"Preset voices to use for the speech.",
    };

    private static Option<global::DeepInfra.TtsResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"response format for the speech",
    };

    private static Option<double?> Speed { get; } = new(
        name: @"--speed")
    {
        Description = @"speed of the speech",
    };

    private static Option<object?> ExtraBody { get; } = new(
        name: @"--extra-body")
    {
        Description = @"Extra body parameters for the model.",
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


    public static Command Create()
    {
        var command = new Command(@"openai-audio-speech", @"Openai Audio Speech");
                        command.Options.Add(XDeepinfraSource);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(ServiceTier);
                        command.Options.Add(FailFast);
                        command.Options.Add(Model);
                        command.Options.Add(InputOption);
                        command.Options.Add(Voice);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(Speed);
                        command.Options.Add(ExtraBody);
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
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var serviceTier = CliRuntime.WasSpecified(parseResult, ServiceTier) ? parseResult.GetValue(ServiceTier) : (__requestBase is { } __ServiceTierBaseValue ? __ServiceTierBaseValue.ServiceTier : default);
                        var failFast = CliRuntime.WasSpecified(parseResult, FailFast) ? parseResult.GetValue(FailFast) : (__requestBase is { } __FailFastBaseValue ? __FailFastBaseValue.FailFast : default);
                        var model = parseResult.GetRequiredValue(Model);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var voice = CliRuntime.WasSpecified(parseResult, Voice) ? parseResult.GetValue(Voice) : (__requestBase is { } __VoiceBaseValue ? __VoiceBaseValue.Voice : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var speed = CliRuntime.WasSpecified(parseResult, Speed) ? parseResult.GetValue(Speed) : (__requestBase is { } __SpeedBaseValue ? __SpeedBaseValue.Speed : default);
                        var extraBody = CliRuntime.WasSpecified(parseResult, ExtraBody) ? parseResult.GetValue(ExtraBody) : (__requestBase is { } __ExtraBodyBaseValue ? __ExtraBodyBaseValue.ExtraBody : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Audio.OpenaiAudioSpeechAsync(
                                    xDeepinfraSource: xDeepinfraSource,
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    serviceTier: serviceTier,
                                    failFast: failFast,
                                    model: model,
                                    input: input,
                                    voice: voice,
                                    responseFormat: responseFormat,
                                    speed: speed,
                                    extraBody: extraBody,
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