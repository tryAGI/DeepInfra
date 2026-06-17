#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class SetupTopupCommandApiCommand
{
    private static Option<object?> Session { get; } = new(
        name: @"--session")
    {
        Description = @"",
    };

    private static Option<int?> Amount { get; } = new(
        name: @"--amount")
    {
        Description = @"Amount to top up in cents",
    };

    private static Option<int?> Threshold { get; } = new(
        name: @"--threshold")
    {
        Description = @"Top up threshold in cents, if balance goes below this value, top up will be triggered",
    };

    private static Option<bool?> Enabled { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enabled",
        description: @"If true, top up will be triggered when balance goes below threshold");
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
        var command = new Command(@"setup-topup", @"Setup Topup");
                        command.Options.Add(Session);
                        command.Options.Add(Amount);
                        command.Options.Add(Threshold);
                        command.Options.Add(Enabled);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.TopUpIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var session = parseResult.GetValue(Session);
                        var amount = CliRuntime.WasSpecified(parseResult, Amount) ? parseResult.GetValue(Amount) : (__requestBase is { } __AmountBaseValue ? __AmountBaseValue.Amount : default);
                        var threshold = CliRuntime.WasSpecified(parseResult, Threshold) ? parseResult.GetValue(Threshold) : (__requestBase is { } __ThresholdBaseValue ? __ThresholdBaseValue.Threshold : default);
                        var enabled = CliRuntime.WasSpecified(parseResult, Enabled) ? parseResult.GetValue(Enabled) : (__requestBase is { } __EnabledBaseValue ? __EnabledBaseValue.Enabled : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.SetupTopupAsync(
                                    session: session,
                                    amount: amount,
                                    threshold: threshold,
                                    enabled: enabled,
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