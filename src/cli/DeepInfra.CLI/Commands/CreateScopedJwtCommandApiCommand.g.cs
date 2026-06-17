#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class CreateScopedJwtCommandApiCommand
{
    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<string> ApiKeyName { get; } = new(
        name: @"--api-key-name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
        name: @"--models")
    {
        Description = @"allow inference only to the specified model names",
    };

    private static Option<int?> ExpiresDelta { get; } = new(
        name: @"--expires-delta")
    {
        Description = @"how many seconds in the future should the token be valid for",
    };

    private static Option<int?> ExpiresAt { get; } = new(
        name: @"--expires-at")
    {
        Description = @"unix timestamp when the token should expire",
    };

    private static Option<double?> SpendingLimit { get; } = new(
        name: @"--spending-limit")
    {
        Description = @"only allow spending that much USD until the token becomes invalid",
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

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.ScopedJWTOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.ScopedJWTOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-scoped-jwt", @" Create Scoped Jwt");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(ApiKeyName);
                        command.Options.Add(Models);
                        command.Options.Add(ExpiresDelta);
                        command.Options.Add(ExpiresAt);
                        command.Options.Add(SpendingLimit);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.ScopedJWTIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var apiKeyName = parseResult.GetRequiredValue(ApiKeyName);
                        var models = CliRuntime.WasSpecified(parseResult, Models) ? parseResult.GetValue(Models) : (__requestBase is { } __ModelsBaseValue ? __ModelsBaseValue.Models : default);
                        var expiresDelta = CliRuntime.WasSpecified(parseResult, ExpiresDelta) ? parseResult.GetValue(ExpiresDelta) : (__requestBase is { } __ExpiresDeltaBaseValue ? __ExpiresDeltaBaseValue.ExpiresDelta : default);
                        var expiresAt = CliRuntime.WasSpecified(parseResult, ExpiresAt) ? parseResult.GetValue(ExpiresAt) : (__requestBase is { } __ExpiresAtBaseValue ? __ExpiresAtBaseValue.ExpiresAt : default);
                        var spendingLimit = CliRuntime.WasSpecified(parseResult, SpendingLimit) ? parseResult.GetValue(SpendingLimit) : (__requestBase is { } __SpendingLimitBaseValue ? __SpendingLimitBaseValue.SpendingLimit : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateScopedJwtAsync(
                                    xiApiKey: xiApiKey,
                                    apiKeyName: apiKeyName,
                                    models: models,
                                    expiresDelta: expiresDelta,
                                    expiresAt: expiresAt,
                                    spendingLimit: spendingLimit,
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