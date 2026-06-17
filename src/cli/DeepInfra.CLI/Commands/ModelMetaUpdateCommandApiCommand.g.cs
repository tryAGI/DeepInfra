#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ModelMetaUpdateCommandApiCommand
{
    private static Argument<string> ModelName { get; } = new(
        name: @"model-name")
    {
        Description = @"",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"short model description in plain text",
    };

    private static Option<string?> GithubUrl { get; } = new(
        name: @"--github-url")
    {
        Description = @"source code project link (empty to delete)",
    };

    private static Option<string?> PaperUrl { get; } = new(
        name: @"--paper-url")
    {
        Description = @"paper/research link (empty to delete)",
    };

    private static Option<string?> LicenseUrl { get; } = new(
        name: @"--license-url")
    {
        Description = @"usage license link (empty to delete)",
    };

    private static Option<string?> Readme { get; } = new(
        name: @"--readme")
    {
        Description = @"markdown flavored model readme",
    };

    private static Option<string?> CoverImgUrl { get; } = new(
        name: @"--cover-img-url")
    {
        Description = @"dataurl or regular url to cover image (empty to delete)",
    };

    private static Option<global::DeepInfra.HFTasksE?> ReportedType { get; } = new(
        name: @"--reported-type")
    {
        Description = @"model type",
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
        var command = new Command(@"model-meta-update", @"Model Meta Update");
                        command.Arguments.Add(ModelName);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(GithubUrl);
                        command.Options.Add(PaperUrl);
                        command.Options.Add(LicenseUrl);
                        command.Options.Add(Readme);
                        command.Options.Add(CoverImgUrl);
                        command.Options.Add(ReportedType);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.ModelMetaIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var modelName = parseResult.GetRequiredValue(ModelName);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var githubUrl = CliRuntime.WasSpecified(parseResult, GithubUrl) ? parseResult.GetValue(GithubUrl) : (__requestBase is { } __GithubUrlBaseValue ? __GithubUrlBaseValue.GithubUrl : default);
                        var paperUrl = CliRuntime.WasSpecified(parseResult, PaperUrl) ? parseResult.GetValue(PaperUrl) : (__requestBase is { } __PaperUrlBaseValue ? __PaperUrlBaseValue.PaperUrl : default);
                        var licenseUrl = CliRuntime.WasSpecified(parseResult, LicenseUrl) ? parseResult.GetValue(LicenseUrl) : (__requestBase is { } __LicenseUrlBaseValue ? __LicenseUrlBaseValue.LicenseUrl : default);
                        var readme = CliRuntime.WasSpecified(parseResult, Readme) ? parseResult.GetValue(Readme) : (__requestBase is { } __ReadmeBaseValue ? __ReadmeBaseValue.Readme : default);
                        var coverImgUrl = CliRuntime.WasSpecified(parseResult, CoverImgUrl) ? parseResult.GetValue(CoverImgUrl) : (__requestBase is { } __CoverImgUrlBaseValue ? __CoverImgUrlBaseValue.CoverImgUrl : default);
                        var reportedType = CliRuntime.WasSpecified(parseResult, ReportedType) ? parseResult.GetValue(ReportedType) : (__requestBase is { } __ReportedTypeBaseValue ? __ReportedTypeBaseValue.ReportedType : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ModelMetaUpdateAsync(
                                    modelName: modelName,
                                    xiApiKey: xiApiKey,
                                    description: description,
                                    githubUrl: githubUrl,
                                    paperUrl: paperUrl,
                                    licenseUrl: licenseUrl,
                                    readme: readme,
                                    coverImgUrl: coverImgUrl,
                                    reportedType: reportedType,
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