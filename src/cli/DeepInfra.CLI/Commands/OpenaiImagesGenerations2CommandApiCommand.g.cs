#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class OpenaiImagesGenerations2CommandApiCommand
{
    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<global::DeepInfra.OpenAIImagesResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"The format in which the generated images are returned. Currently only b64_json is supported.",
    };
    private static readonly OpenAIImagesGenerationsInOptionSet OpenAIImagesGenerationsInOptionSetOptions = OpenAIImagesGenerationsInOptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.OpenAIImagesOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.OpenAIImagesOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"openai-images-generations2", @"Openai Images Generations
Generate image using OpenAI Images API");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(ResponseFormat);                        command.Options.Add(OpenAIImagesGenerationsInOptionSetOptions.Model);
                        command.Options.Add(OpenAIImagesGenerationsInOptionSetOptions.N);
                        command.Options.Add(OpenAIImagesGenerationsInOptionSetOptions.Size);
                        command.Options.Add(OpenAIImagesGenerationsInOptionSetOptions.User);
                        command.Options.Add(OpenAIImagesGenerationsInOptionSetOptions.Prompt);
                        command.Options.Add(OpenAIImagesGenerationsInOptionSetOptions.Quality);
                        command.Options.Add(OpenAIImagesGenerationsInOptionSetOptions.Style);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.OpenAIImagesGenerationsIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);                        var model = parseResult.GetRequiredValue(OpenAIImagesGenerationsInOptionSetOptions.Model);
                        var n = CliRuntime.WasSpecified(parseResult, OpenAIImagesGenerationsInOptionSetOptions.N) ? parseResult.GetValue(OpenAIImagesGenerationsInOptionSetOptions.N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var size = CliRuntime.WasSpecified(parseResult, OpenAIImagesGenerationsInOptionSetOptions.Size) ? parseResult.GetValue(OpenAIImagesGenerationsInOptionSetOptions.Size) : (__requestBase is { } __SizeBaseValue ? __SizeBaseValue.Size : default);
                        var user = CliRuntime.WasSpecified(parseResult, OpenAIImagesGenerationsInOptionSetOptions.User) ? parseResult.GetValue(OpenAIImagesGenerationsInOptionSetOptions.User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                        var prompt = parseResult.GetRequiredValue(OpenAIImagesGenerationsInOptionSetOptions.Prompt);
                        var quality = CliRuntime.WasSpecified(parseResult, OpenAIImagesGenerationsInOptionSetOptions.Quality) ? parseResult.GetValue(OpenAIImagesGenerationsInOptionSetOptions.Quality) : (__requestBase is { } __QualityBaseValue ? __QualityBaseValue.Quality : default);
                        var style = CliRuntime.WasSpecified(parseResult, OpenAIImagesGenerationsInOptionSetOptions.Style) ? parseResult.GetValue(OpenAIImagesGenerationsInOptionSetOptions.Style) : (__requestBase is { } __StyleBaseValue ? __StyleBaseValue.Style : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenaiImagesGenerations2Async(
                                    xiApiKey: xiApiKey,
                                    responseFormat: responseFormat,
                                    model: model,
                                    n: n,
                                    size: size,
                                    user: user,
                                    prompt: prompt,
                                    quality: quality,
                                    style: style,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::DeepInfra.SourceGenerationContext.Default,
                                        @"Data",
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