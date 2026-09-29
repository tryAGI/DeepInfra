#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class VideosCreateVideoGenerationCommandApiCommand
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
    private static readonly VideoGenerationInOptionSet VideoGenerationInOptionSetOptions = VideoGenerationInOptionSet.Create();
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
      private static Option<bool> Wait { get; } = new("--wait")
      {
          Description = "Poll the generated wait helper until the resource reaches a terminal state.",
      };

      private static Option<string> PollInterval { get; } = new("--poll-interval")
      {
          Description = "Polling interval, for example 250ms, 2s, 30m, or 01:00:00.",
          DefaultValueFactory = _ => "2s",
      };

      private static Option<string> WaitTimeout { get; } = new("--wait-timeout")
      {
          Description = "Maximum time to wait before timing out, for example 30m or 00:30:00.",
          DefaultValueFactory = _ => "30m",
      };

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.VideoGenerationOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.VideoGenerationOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-video-generation", @"Create Video Generation");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);                        command.Options.Add(VideoGenerationInOptionSetOptions.Model);
                        command.Options.Add(VideoGenerationInOptionSetOptions.Prompt);
                        command.Options.Add(VideoGenerationInOptionSetOptions.NegativePrompt);
                        command.Options.Add(VideoGenerationInOptionSetOptions.AspectRatio);
                        command.Options.Add(VideoGenerationInOptionSetOptions.Size);
                        command.Options.Add(VideoGenerationInOptionSetOptions.Seconds);
                        command.Options.Add(VideoGenerationInOptionSetOptions.Seed);
                        command.Options.Add(VideoGenerationInOptionSetOptions.Style);
                        command.Options.Add(VideoGenerationInOptionSetOptions.ImageUrl);
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
          command.Options.Add(Wait);
          command.Options.Add(PollInterval);
          command.Options.Add(WaitTimeout);
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.VideoGenerationIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);                        var model = parseResult.GetRequiredValue(VideoGenerationInOptionSetOptions.Model);
                        var prompt = parseResult.GetRequiredValue(VideoGenerationInOptionSetOptions.Prompt);
                        var negativePrompt = CliRuntime.WasSpecified(parseResult, VideoGenerationInOptionSetOptions.NegativePrompt) ? parseResult.GetValue(VideoGenerationInOptionSetOptions.NegativePrompt) : (__requestBase is { } __NegativePromptBaseValue ? __NegativePromptBaseValue.NegativePrompt : default);
                        var aspectRatio = CliRuntime.WasSpecified(parseResult, VideoGenerationInOptionSetOptions.AspectRatio) ? parseResult.GetValue(VideoGenerationInOptionSetOptions.AspectRatio) : (__requestBase is { } __AspectRatioBaseValue ? __AspectRatioBaseValue.AspectRatio : default);
                        var size = CliRuntime.WasSpecified(parseResult, VideoGenerationInOptionSetOptions.Size) ? parseResult.GetValue(VideoGenerationInOptionSetOptions.Size) : (__requestBase is { } __SizeBaseValue ? __SizeBaseValue.Size : default);
                        var seconds = CliRuntime.WasSpecified(parseResult, VideoGenerationInOptionSetOptions.Seconds) ? parseResult.GetValue(VideoGenerationInOptionSetOptions.Seconds) : (__requestBase is { } __SecondsBaseValue ? __SecondsBaseValue.Seconds : default);
                        var seed = CliRuntime.WasSpecified(parseResult, VideoGenerationInOptionSetOptions.Seed) ? parseResult.GetValue(VideoGenerationInOptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var style = CliRuntime.WasSpecified(parseResult, VideoGenerationInOptionSetOptions.Style) ? parseResult.GetValue(VideoGenerationInOptionSetOptions.Style) : (__requestBase is { } __StyleBaseValue ? __StyleBaseValue.Style : default);
                        var imageUrl = CliRuntime.WasSpecified(parseResult, VideoGenerationInOptionSetOptions.ImageUrl) ? parseResult.GetValue(VideoGenerationInOptionSetOptions.ImageUrl) : (__requestBase is { } __ImageUrlBaseValue ? __ImageUrlBaseValue.ImageUrl : default);          var wait = parseResult.GetValue(Wait);
          var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
          var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                if (wait)
                                {
                                var createResponse = await client.Videos.CreateVideoGenerationAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    model: model,
                                    prompt: prompt,
                                    negativePrompt: negativePrompt,
                                    aspectRatio: aspectRatio,
                                    size: size,
                                    seconds: seconds,
                                    seed: seed,
                                    style: style,
                                    imageUrl: imageUrl,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);
                                    var resourceId = global::System.Convert.ToString(
                                        createResponse.Id,
                                        global::System.Globalization.CultureInfo.InvariantCulture);
                                    if (string.IsNullOrWhiteSpace(resourceId))
                                    {
                                        throw new CliException("The create response did not contain a job id.");
                                    }

                                    var waitResponse = await CliRuntime.PollUntilTerminalAsync(
                                        fetchAsync: token => client.Videos.GetVideoGenerationAsync(
                                            videoId: resourceId,
                                            cancellationToken: token),
                                        pollInterval: pollInterval,
                                        waitTimeout: waitTimeout,
                                        context: global::DeepInfra.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    await CliRuntime.WriteResponseAsync(
                                        parseResult,
                                        waitResponse,
                                        global::DeepInfra.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    return;
                                }

                                var response = await client.Videos.CreateVideoGenerationAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    model: model,
                                    prompt: prompt,
                                    negativePrompt: negativePrompt,
                                    aspectRatio: aspectRatio,
                                    size: size,
                                    seconds: seconds,
                                    seed: seed,
                                    style: style,
                                    imageUrl: imageUrl,
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