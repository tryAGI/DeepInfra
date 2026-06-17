#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ContainerRentalsStartCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Container Name",
    };

    private static Option<string?> XiApiKey { get; } = new(
        name: @"--xi-api-key")
    {
        Description = @"",
    };

    private static Option<string> GpuConfig { get; } = new(
        name: @"--gpu-config")
    {
        Description = @"GPU config",
        Required = true,
    };

    private static Option<string> ContainerImage { get; } = new(
        name: @"--container-image")
    {
        Description = @"Container Image",
        Required = true,
    };

    private static Option<string> CloudInitUserData { get; } = new(
        name: @"--cloud-init-user-data")
    {
        Description = @"Cloud Init User Data",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.ContainerRentalStartOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.ContainerRentalStartOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"container-rentals-start", @"Container Rentals Start");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(GpuConfig);
                        command.Options.Add(ContainerImage);
                        command.Options.Add(CloudInitUserData);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetRequiredValue(NameOption);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var gpuConfig = parseResult.GetRequiredValue(GpuConfig);
                        var containerImage = parseResult.GetRequiredValue(ContainerImage);
                        var cloudInitUserData = parseResult.GetRequiredValue(CloudInitUserData);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ContainerRentalsStartAsync(
                                    name: name,
                                    xiApiKey: xiApiKey,
                                    gpuConfig: gpuConfig,
                                    containerImage: containerImage,
                                    cloudInitUserData: cloudInitUserData,
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