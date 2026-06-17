#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ModelSchemaCommandApiCommand
{
    private static Argument<string> ModelName { get; } = new(
        name: @"model-name")
    {
        Description = @"",
    };

    private static Argument<global::DeepInfra.SchemaVariantKey> VariantKey { get; } = new(
        name: @"variant-key")
    {
        Description = @"",
    };

    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.SchemaOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.SchemaOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"model-schema", @"Model Schema");
                        command.Arguments.Add(ModelName);
                        command.Arguments.Add(VariantKey);
                        command.Options.Add(Version);
                        command.Options.Add(XiApiKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelName = parseResult.GetRequiredValue(ModelName);
                        var variantKey = parseResult.GetRequiredValue(VariantKey);
                        var version = parseResult.GetValue(Version);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ModelSchemaAsync(
                                    modelName: modelName,
                                    variantKey: variantKey,
                                    version: version,
                                    xiApiKey: xiApiKey,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::DeepInfra.SourceGenerationContext.Default,
                                        @"FieldsIn",
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