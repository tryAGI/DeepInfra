#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class AuthenticationExportApiTokenToVercelByBodyCommandApiCommand
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

    private static Option<string> ProjectIdOrName { get; } = new(
        name: @"--project-id-or-name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<bool> IsSensitive { get; } = new(
        name: @"--is-sensitive")
    {
        Description = @"",
        Required = true,
    };

    private static Option<bool> EnvDevelopment { get; } = new(
        name: @"--env-development")
    {
        Description = @"",
        Required = true,
    };

    private static Option<bool> EnvPreview { get; } = new(
        name: @"--env-preview")
    {
        Description = @"",
        Required = true,
    };

    private static Option<bool> EnvProduction { get; } = new(
        name: @"--env-production")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> ApiToken { get; } = new(
        name: @"--api-token")
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
        var command = new Command(@"export-api-token-to-vercel-by-body", @"Export Api Token To Vercel By Body");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(ProjectIdOrName);
                        command.Options.Add(IsSensitive);
                        command.Options.Add(EnvDevelopment);
                        command.Options.Add(EnvPreview);
                        command.Options.Add(EnvProduction);
                        command.Options.Add(ApiToken);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.ApiTokenVercelExportBodyIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var projectIdOrName = parseResult.GetRequiredValue(ProjectIdOrName);
                        var isSensitive = parseResult.GetRequiredValue(IsSensitive);
                        var envDevelopment = parseResult.GetRequiredValue(EnvDevelopment);
                        var envPreview = parseResult.GetRequiredValue(EnvPreview);
                        var envProduction = parseResult.GetRequiredValue(EnvProduction);
                        var apiToken = CliRuntime.WasSpecified(parseResult, ApiToken) ? parseResult.GetValue(ApiToken) : (__requestBase is { } __ApiTokenBaseValue ? __ApiTokenBaseValue.ApiToken : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Authentication.ExportApiTokenToVercelByBodyAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    projectIdOrName: projectIdOrName,
                                    isSensitive: isSensitive,
                                    envDevelopment: envDevelopment,
                                    envPreview: envPreview,
                                    envProduction: envProduction,
                                    apiToken: apiToken,
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