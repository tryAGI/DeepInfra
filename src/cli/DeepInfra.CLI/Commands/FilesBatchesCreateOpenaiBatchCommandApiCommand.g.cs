#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class FilesBatchesCreateOpenaiBatchCommandApiCommand
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

    private static Option<string> InputFileId { get; } = new(
        name: @"--input-file-id")
    {
        Description = @"The ID of an uploaded file that contains requests for the new batch.",
        Required = true,
    };

    private static Option<global::DeepInfra.OpenAIBatchesInEndpoint> Endpoint { get; } = new(
        name: @"--endpoint")
    {
        Description = @"The endpoint to be used for all requests in the batch. Currently /v1/chat/completions, /v1/completions, /v1/embeddings are supported.",
        Required = true,
    };

    private static Option<string> CompletionWindow { get; } = new(
        name: @"--completion-window")
    {
        Description = @"The time frame within which the batch should be processed. Currently only 24h is supported.",
        DefaultValueFactory = _ => "24h",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Optional metadata to be stored with the batch.",
    };

    private static Option<global::DeepInfra.BatchOutputExpiresAfter?> OutputExpiresAfter { get; } = new(
        name: @"--output-expires-after")
    {
        Description = @"The expiration policy for the output and/or error file generated for the batch.",
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

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.OpenAIBatchesOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.OpenAIBatchesOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-openai-batch", @"Create Openai Batch");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(InputFileId);
                        command.Options.Add(Endpoint);
                        command.Options.Add(CompletionWindow);
                        command.Options.Add(Metadata);
                        command.Options.Add(OutputExpiresAfter);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.OpenAIBatchesIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var inputFileId = parseResult.GetRequiredValue(InputFileId);
                        var endpoint = parseResult.GetRequiredValue(Endpoint);
                        var completionWindow = parseResult.GetRequiredValue(CompletionWindow);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var outputExpiresAfter = CliRuntime.WasSpecified(parseResult, OutputExpiresAfter) ? parseResult.GetValue(OutputExpiresAfter) : (__requestBase is { } __OutputExpiresAfterBaseValue ? __OutputExpiresAfterBaseValue.OutputExpiresAfter : default);          var wait = parseResult.GetValue(Wait);
          var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
          var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                if (wait)
                                {
                                var createResponse = await client.FilesBatches.CreateOpenaiBatchAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    inputFileId: inputFileId,
                                    endpoint: endpoint,
                                    completionWindow: completionWindow,
                                    metadata: metadata,
                                    outputExpiresAfter: outputExpiresAfter,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);
                                    var resourceId = global::System.Convert.ToString(
                                        createResponse.Id,
                                        global::System.Globalization.CultureInfo.InvariantCulture);
                                    if (string.IsNullOrWhiteSpace(resourceId))
                                    {
                                        throw new CliException("The create response did not contain a job id.");
                                    }

                                    var waitResponse = await CliRuntime.PollUntilTerminalAsync(
                                        fetchAsync: token => client.FilesBatches.RetrieveOpenaiBatchAsync(
                                            batchId: resourceId,
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

                                var response = await client.FilesBatches.CreateOpenaiBatchAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    inputFileId: inputFileId,
                                    endpoint: endpoint,
                                    completionWindow: completionWindow,
                                    metadata: metadata,
                                    outputExpiresAfter: outputExpiresAfter,
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