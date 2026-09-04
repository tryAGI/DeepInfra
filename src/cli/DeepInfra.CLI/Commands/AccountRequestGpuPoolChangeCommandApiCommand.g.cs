#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class AccountRequestGpuPoolChangeCommandApiCommand
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

    private static Option<string> Reason { get; } = new(
        name: @"--reason")
    {
        Description = @"Why you need the change. Shown to the reviewer.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, int>?> RequestedMin { get; } = new(
        name: @"--requested-min")
    {
        Description = @"Guaranteed capacity.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, int>?> RequestedMax { get; } = new(
        name: @"--requested-max")
    {
        Description = @"Desired max GPUs per type, e.g. {""H100-80GB"": 16}. REPLACES the contents of your pending request, so send every entry you still want changed.",
    };

    private static Option<string?> ExpectedRequestId { get; } = new(
        name: @"--expected-request-id")
    {
        Description = @"Id of the pending request you are editing, from GET /v1/me/gpu_pool (pending_request.id), or null if you have none.",
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

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.GpuPoolPendingRequestOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.GpuPoolPendingRequestOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"request-gpu-pool-change", @"Request Gpu Pool Change
File or amend the caller's single open GPU limit request.");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(Reason);
                        command.Options.Add(RequestedMin);
                        command.Options.Add(RequestedMax);
                        command.Options.Add(ExpectedRequestId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.GpuPoolRequestIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var reason = parseResult.GetRequiredValue(Reason);
                        var requestedMin = CliRuntime.WasSpecified(parseResult, RequestedMin) ? parseResult.GetValue(RequestedMin) : (__requestBase is { } __RequestedMinBaseValue ? __RequestedMinBaseValue.RequestedMin : default);
                        var requestedMax = CliRuntime.WasSpecified(parseResult, RequestedMax) ? parseResult.GetValue(RequestedMax) : (__requestBase is { } __RequestedMaxBaseValue ? __RequestedMaxBaseValue.RequestedMax : default);
                        var expectedRequestId = CliRuntime.WasSpecified(parseResult, ExpectedRequestId) ? parseResult.GetValue(ExpectedRequestId) : (__requestBase is { } __ExpectedRequestIdBaseValue ? __ExpectedRequestIdBaseValue.ExpectedRequestId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Account.RequestGpuPoolChangeAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    reason: reason,
                                    requestedMin: requestedMin,
                                    requestedMax: requestedMax,
                                    expectedRequestId: expectedRequestId,
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