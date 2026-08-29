#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class LoRAAdaptersUploadLoraModelCommandApiCommand
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

    private static Option<string> HfModelName { get; } = new(
        name: @"--hf-model-name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> HfToken { get; } = new(
        name: @"--hf-token")
    {
        Description = @"",
    };

    private static Option<string> LoraModelName { get; } = new(
        name: @"--lora-model-name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> BaseModelName { get; } = new(
        name: @"--base-model-name")
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

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.DeploymentOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.DeploymentOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"upload-lora-model", @"Upload Lora Model");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(HfModelName);
                        command.Options.Add(HfToken);
                        command.Options.Add(LoraModelName);
                        command.Options.Add(BaseModelName);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.LoraModelUploadIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var hfModelName = parseResult.GetRequiredValue(HfModelName);
                        var hfToken = CliRuntime.WasSpecified(parseResult, HfToken) ? parseResult.GetValue(HfToken) : (__requestBase is { } __HfTokenBaseValue ? __HfTokenBaseValue.HfToken : default);
                        var loraModelName = parseResult.GetRequiredValue(LoraModelName);
                        var baseModelName = CliRuntime.WasSpecified(parseResult, BaseModelName) ? parseResult.GetValue(BaseModelName) : (__requestBase is { } __BaseModelNameBaseValue ? __BaseModelNameBaseValue.BaseModelName : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LoRAAdapters.UploadLoraModelAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    hfModelName: hfModelName,
                                    hfToken: hfToken,
                                    loraModelName: loraModelName,
                                    baseModelName: baseModelName,
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