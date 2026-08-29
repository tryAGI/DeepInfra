#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class DedicatedModelsDeployLlmPresetsCommandApiCommand
{
    private static Option<string> HfRepoId { get; } = new(
        name: @"--hf-repo-id")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::DeepInfra.DeployGPUs?> Gpu { get; } = new(
        name: @"--gpu")
    {
        Description = @"",
    };

    private static Option<string?> Engine { get; } = new(
        name: @"--engine")
    {
        Description = @"",
    };

    private static Option<string?> Source { get; } = new(
        name: @"--source")
    {
        Description = @"",
    };

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

                    private static string FormatResponse(ParseResult parseResult, global::System.Collections.Generic.IList<global::DeepInfra.PresetConfigOut> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::System.Collections.Generic.IList<global::DeepInfra.PresetConfigOut> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"deploy-llm-presets", @"Deploy Llm Presets
DeepInfra presets and mirrored vLLM recipes for ``hf_repo_id``, told apart by
``source``; empty when none. Filter by ``gpu``/``engine``/``source``.");
                        command.Options.Add(HfRepoId);
                        command.Options.Add(Gpu);
                        command.Options.Add(Engine);
                        command.Options.Add(Source);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var hfRepoId = parseResult.GetRequiredValue(HfRepoId);
                        var gpu = parseResult.GetValue(Gpu);
                        var engine = parseResult.GetValue(Engine);
                        var source = parseResult.GetValue(Source);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DedicatedModels.DeployLlmPresetsAsync(
                                    hfRepoId: hfRepoId,
                                    gpu: gpu,
                                    engine: engine,
                                    source: source,
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::DeepInfra.SourceGenerationContext.Default,
                                        @"$self",
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