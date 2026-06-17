#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class OpenaiImagesVariationsCommandApiCommand
{
    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<byte[]> Image { get; } = new(
        name: @"--image")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Imagename { get; } = new(
        name: @"--imagename")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
        Required = true,
    };
    private static readonly OpenAIImagesVariationsInOptionSet InpOptions = OpenAIImagesVariationsInOptionSet.Create(@"inp");
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
        var command = new Command(@"openai-images-variations", @"Openai Images Variations
Generate a similar image using OpenAI Images Variations API");
                        command.Options.Add(XiApiKey);
                        command.Options.Add(Image);
                        command.Options.Add(Imagename);
                        command.Options.Add(Model);                        command.Options.Add(InpOptions.Model);
                        command.Options.Add(InpOptions.N);
                        command.Options.Add(InpOptions.Size);
                        command.Options.Add(InpOptions.User);
                        command.Options.Add(InpOptions.Imagename);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.BodyOpenaiImagesVariationsV1ImagesVariationsPost>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var image = parseResult.GetRequiredValue(Image);
                        var imagename = parseResult.GetRequiredValue(Imagename);
                        var model = parseResult.GetRequiredValue(Model);

                        var __InpBase = __requestBase is { } __InpBaseValue ? __InpBaseValue.Inp : default;                        var inpModel = parseResult.GetValue(InpOptions.Model);
                        var inpN = CliRuntime.WasSpecified(parseResult, InpOptions.N) ? parseResult.GetValue(InpOptions.N) : (__InpBase is { } __InpnBaseValue ? __InpnBaseValue.N : default);
                        var inpSize = CliRuntime.WasSpecified(parseResult, InpOptions.Size) ? parseResult.GetValue(InpOptions.Size) : (__InpBase is { } __InpsizeBaseValue ? __InpsizeBaseValue.Size : default);
                        var inpUser = CliRuntime.WasSpecified(parseResult, InpOptions.User) ? parseResult.GetValue(InpOptions.User) : (__InpBase is { } __InpuserBaseValue ? __InpuserBaseValue.User : default);
                        var inpImagename = parseResult.GetValue(InpOptions.Imagename);
                        var __InpSpecified = CliRuntime.WasSpecified(parseResult, InpOptions.Model) || CliRuntime.WasSpecified(parseResult, InpOptions.N) || CliRuntime.WasSpecified(parseResult, InpOptions.Size) || CliRuntime.WasSpecified(parseResult, InpOptions.User) || CliRuntime.WasSpecified(parseResult, InpOptions.Imagename);
                        var inp =
                            __InpSpecified || __InpBase is not null
                                ? new global::DeepInfra.OpenAIImagesVariationsIn
                                {
	                                Model = inpModel!,
                                N = inpN,
                                Size = inpSize,
                                User = inpUser,
                                Imagename = inpImagename!,
	                                Image = __InpBase is not null ? __InpBase.Image : throw new CliException(@"Inp.image is required when using inp options. Provide it with --request-json or --request-file."),
                                }
                                : __InpBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OpenaiImagesVariationsAsync(
                                    xiApiKey: xiApiKey,
                                    image: image,
                                    imagename: imagename,
                                    model: model,
                                    inp: inp,
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