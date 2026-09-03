#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ImageGenerationOpenaiImagesGenerationsCommandApiCommand
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

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use for image generation.",
        Required = true,
    };

    private static Option<int?> N { get; } = new(
        name: @"--n")
    {
        Description = @"The number of images to generate.",
    };

    private static Option<global::DeepInfra.OpenAIImagesResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"The format in which the generated images are returned: 'b64_json' (default) or 'url'. For most models 'url' points to a temporary copy we host that expires after about a day; for some provider-backed models it is the provider's own URL with the provider's own lifetime.",
    };

    private static Option<string?> Size { get; } = new(
        name: @"--size")
    {
        Description = @"The size of the generated images. Available sizes depend on the model.",
    };

    private static Option<string?> User { get; } = new(
        name: @"--user")
    {
        Description = @"A unique identifier representing your end-user, which can help to monitor and detect abuse.",
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"A text description of desired image(s).",
        Required = true,
    };

    private static Option<string?> Quality { get; } = new(
        name: @"--quality")
    {
        Description = @"The quality of the image that will be generated.",
    };

    private static Option<string?> Style { get; } = new(
        name: @"--style")
    {
        Description = @"The style of the generated images.",
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
        var command = new Command(@"openai-images-generations", @"Openai Images Generations
Generate image using OpenAI Images API");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(Model);
                        command.Options.Add(N);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(Size);
                        command.Options.Add(User);
                        command.Options.Add(Prompt);
                        command.Options.Add(Quality);
                        command.Options.Add(Style);
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
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var model = parseResult.GetRequiredValue(Model);
                        var n = CliRuntime.WasSpecified(parseResult, N) ? parseResult.GetValue(N) : (__requestBase is { } __NBaseValue ? __NBaseValue.N : default);
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : (__requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default);
                        var size = CliRuntime.WasSpecified(parseResult, Size) ? parseResult.GetValue(Size) : (__requestBase is { } __SizeBaseValue ? __SizeBaseValue.Size : default);
                        var user = CliRuntime.WasSpecified(parseResult, User) ? parseResult.GetValue(User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var quality = CliRuntime.WasSpecified(parseResult, Quality) ? parseResult.GetValue(Quality) : (__requestBase is { } __QualityBaseValue ? __QualityBaseValue.Quality : default);
                        var style = CliRuntime.WasSpecified(parseResult, Style) ? parseResult.GetValue(Style) : (__requestBase is { } __StyleBaseValue ? __StyleBaseValue.Style : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ImageGeneration.OpenaiImagesGenerationsAsync(
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    model: model,
                                    n: n,
                                    responseFormat: responseFormat,
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