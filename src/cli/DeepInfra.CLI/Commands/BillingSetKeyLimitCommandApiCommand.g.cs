#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class BillingSetKeyLimitCommandApiCommand
{
    private static Option<object?> Session { get; } = new(
        name: @"--session")
    {
        Description = @"",
    };

    private static Option<string> TokenId { get; } = new(
        name: @"--token-id")
    {
        Description = @"Api key id, as returned by /v1/api-tokens",
        Required = true,
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Monthly spending limit (in USD) for this key. Null or negative removes it; 0 blocks the key",
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

                    private static string FormatResponse(ParseResult parseResult, global::System.Collections.Generic.IList<global::DeepInfra.KeyLimitOut> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::System.Collections.Generic.IList<global::DeepInfra.KeyLimitOut> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"set-key-limit", @"Set Key Limit");
                        command.Options.Add(Session);
                        command.Options.Add(TokenId);
                        command.Options.Add(Limit);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.KeyLimitIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var session = parseResult.GetValue(Session);
                        var tokenId = parseResult.GetRequiredValue(TokenId);
                        var limit = CliRuntime.WasSpecified(parseResult, Limit) ? parseResult.GetValue(Limit) : (__requestBase is { } __LimitBaseValue ? __LimitBaseValue.Limit : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Billing.SetKeyLimitAsync(
                                    session: session,
                                    tokenId: tokenId,
                                    limit: limit,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::DeepInfra.SourceGenerationContext.Default,
                                        @"$self",
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
        return command;
    }
}