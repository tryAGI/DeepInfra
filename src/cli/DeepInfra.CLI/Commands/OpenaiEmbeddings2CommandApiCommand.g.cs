#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class OpenaiEmbeddings2CommandApiCommand
{
    private static Option<string?> XDeepinfraSource { get; } = new(
        name: @"--x-deepinfra-source")
    {
        Description = @"",
    };

    private static Option<string?> UserAgent { get; } = new(
        name: @"--user-agent")
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

    private static Option<global::DeepInfra.AnyOf<global::System.Collections.Generic.IList<string>, string>> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"sequences to embed",
        Required = true,
    };
    private static readonly OpenAIEmbeddingsInOptionSet OpenAIEmbeddingsInOptionSetOptions = OpenAIEmbeddingsInOptionSet.Create();
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
        var command = new Command(@"openai-embeddings2", @"Openai Embeddings");
                        command.Options.Add(XDeepinfraSource);
                        command.Options.Add(UserAgent);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(ServiceTier);
                        command.Options.Add(InputOption);                        command.Options.Add(OpenAIEmbeddingsInOptionSetOptions.Model);
                        command.Options.Add(OpenAIEmbeddingsInOptionSetOptions.EncodingFormat);
                        command.Options.Add(OpenAIEmbeddingsInOptionSetOptions.Dimensions);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.OpenAIEmbeddingsIn>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xDeepinfraSource = parseResult.GetValue(XDeepinfraSource);
                        var userAgent = parseResult.GetValue(UserAgent);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var serviceTier = CliRuntime.WasSpecified(parseResult, ServiceTier) ? parseResult.GetValue(ServiceTier) : (__requestBase is { } __ServiceTierBaseValue ? __ServiceTierBaseValue.ServiceTier : default);
                        var input = parseResult.GetRequiredValue(InputOption);                        var model = parseResult.GetRequiredValue(OpenAIEmbeddingsInOptionSetOptions.Model);
                        var encodingFormat = CliRuntime.WasSpecified(parseResult, OpenAIEmbeddingsInOptionSetOptions.EncodingFormat) ? parseResult.GetValue(OpenAIEmbeddingsInOptionSetOptions.EncodingFormat) : (__requestBase is { } __EncodingFormatBaseValue ? __EncodingFormatBaseValue.EncodingFormat : default);
                        var dimensions = CliRuntime.WasSpecified(parseResult, OpenAIEmbeddingsInOptionSetOptions.Dimensions) ? parseResult.GetValue(OpenAIEmbeddingsInOptionSetOptions.Dimensions) : (__requestBase is { } __DimensionsBaseValue ? __DimensionsBaseValue.Dimensions : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenaiEmbeddings2Async(
                                    xDeepinfraSource: xDeepinfraSource,
                                    userAgent: userAgent,
                                    xiApiKey: xiApiKey,
                                    serviceTier: serviceTier,
                                    input: input,
                                    model: model,
                                    encodingFormat: encodingFormat,
                                    dimensions: dimensions,
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