#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class DeployUpdateCommandApiCommand
{
    private static Argument<string> DeployId { get; } = new(
        name: @"deploy-id")
    {
        Description = @"",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };
    private static readonly ScaleSettingsOptionSet SettingsOptions = ScaleSettingsOptionSet.Create(@"settings");

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.DeployStatusOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.DeployStatusOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"deploy-update", @"Deploy Update");
                        command.Arguments.Add(DeployId);
                        command.Options.Add(XiApiKey);                        command.Options.Add(SettingsOptions.MinInstances);
                        command.Options.Add(SettingsOptions.MaxInstances);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var deployId = parseResult.GetRequiredValue(DeployId);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
	                        var settingsMinInstances = parseResult.GetValue(SettingsOptions.MinInstances);
                        var settingsMaxInstances = parseResult.GetValue(SettingsOptions.MaxInstances);
                        var __SettingsSpecified = CliRuntime.WasSpecified(parseResult, SettingsOptions.MinInstances) || CliRuntime.WasSpecified(parseResult, SettingsOptions.MaxInstances);
                        var settings =
                            __SettingsSpecified || false
                                ? new global::DeepInfra.ScaleSettings
                                {
	                                MinInstances = settingsMinInstances,
                                MaxInstances = settingsMaxInstances,

                                }
                                : null;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DeployUpdateAsync(
                                    deployId: deployId,
                                    xiApiKey: xiApiKey,
                                    settings: settings!,
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