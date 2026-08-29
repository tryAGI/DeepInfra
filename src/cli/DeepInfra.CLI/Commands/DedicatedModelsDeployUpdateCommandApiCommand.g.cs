#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class DedicatedModelsDeployUpdateCommandApiCommand
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

    private static Option<string?> XApiKey { get; } = new(
        name: @"--x-api-key")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ExtraArgs { get; } = new(
        name: @"--extra-args")
    {
        Description = @"Extra engine-specific command-line args (custom-weight deploys only). Replaces the whole list; omitted args are cleared.",
    };
    private static readonly ScaleSettingsOptionSet SettingsOptions = ScaleSettingsOptionSet.Create(@"settings");

    private static readonly StandardArgsOptionSet StandardArgsOptions = StandardArgsOptionSet.Create(@"standard-args");
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
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(ExtraArgs);                        command.Options.Add(SettingsOptions.MinInstances);
                        command.Options.Add(SettingsOptions.MaxInstances);                        command.Options.Add(StandardArgsOptions.MaxContextSize);
                        command.Options.Add(StandardArgsOptions.MaxConcurrentRequests);
                        command.Options.Add(StandardArgsOptions.GpuMemoryFraction);
                        command.Options.Add(StandardArgsOptions.MaxPrefillTokens);
                        command.Options.Add(StandardArgsOptions.EnablePrefixCaching);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.DeployLLMUpdateIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var deployId = parseResult.GetRequiredValue(DeployId);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var extraArgs = CliRuntime.WasSpecified(parseResult, ExtraArgs) ? parseResult.GetValue(ExtraArgs) : (__requestBase is { } __ExtraArgsBaseValue ? __ExtraArgsBaseValue.ExtraArgs : default);

                        var __SettingsBase = __requestBase is { } __SettingsBaseValue ? __SettingsBaseValue.Settings : default;                        var settingsMinInstances = CliRuntime.WasSpecified(parseResult, SettingsOptions.MinInstances) ? parseResult.GetValue(SettingsOptions.MinInstances) : (__SettingsBase is { } __SettingsminInstancesBaseValue ? __SettingsminInstancesBaseValue.MinInstances : default);
                        var settingsMaxInstances = CliRuntime.WasSpecified(parseResult, SettingsOptions.MaxInstances) ? parseResult.GetValue(SettingsOptions.MaxInstances) : (__SettingsBase is { } __SettingsmaxInstancesBaseValue ? __SettingsmaxInstancesBaseValue.MaxInstances : default);
                        var __SettingsSpecified = CliRuntime.WasSpecified(parseResult, SettingsOptions.MinInstances) || CliRuntime.WasSpecified(parseResult, SettingsOptions.MaxInstances);
                        var settings =
                            __SettingsSpecified || __SettingsBase is not null
                                ? new global::DeepInfra.ScaleSettings
                                {
	                                MinInstances = settingsMinInstances,
                                MaxInstances = settingsMaxInstances,

                                }
                                : __SettingsBase;

                        var __StandardArgsBase = __requestBase is { } __StandardArgsBaseValue ? __StandardArgsBaseValue.StandardArgs : default;                        var standardArgsMaxContextSize = CliRuntime.WasSpecified(parseResult, StandardArgsOptions.MaxContextSize) ? parseResult.GetValue(StandardArgsOptions.MaxContextSize) : (__StandardArgsBase is { } __StandardArgsmaxContextSizeBaseValue ? __StandardArgsmaxContextSizeBaseValue.MaxContextSize : default);
                        var standardArgsMaxConcurrentRequests = CliRuntime.WasSpecified(parseResult, StandardArgsOptions.MaxConcurrentRequests) ? parseResult.GetValue(StandardArgsOptions.MaxConcurrentRequests) : (__StandardArgsBase is { } __StandardArgsmaxConcurrentRequestsBaseValue ? __StandardArgsmaxConcurrentRequestsBaseValue.MaxConcurrentRequests : default);
                        var standardArgsGpuMemoryFraction = CliRuntime.WasSpecified(parseResult, StandardArgsOptions.GpuMemoryFraction) ? parseResult.GetValue(StandardArgsOptions.GpuMemoryFraction) : (__StandardArgsBase is { } __StandardArgsgpuMemoryFractionBaseValue ? __StandardArgsgpuMemoryFractionBaseValue.GpuMemoryFraction : default);
                        var standardArgsMaxPrefillTokens = CliRuntime.WasSpecified(parseResult, StandardArgsOptions.MaxPrefillTokens) ? parseResult.GetValue(StandardArgsOptions.MaxPrefillTokens) : (__StandardArgsBase is { } __StandardArgsmaxPrefillTokensBaseValue ? __StandardArgsmaxPrefillTokensBaseValue.MaxPrefillTokens : default);
                        var standardArgsEnablePrefixCaching = CliRuntime.WasSpecified(parseResult, StandardArgsOptions.EnablePrefixCaching) ? parseResult.GetValue(StandardArgsOptions.EnablePrefixCaching) : (__StandardArgsBase is { } __StandardArgsenablePrefixCachingBaseValue ? __StandardArgsenablePrefixCachingBaseValue.EnablePrefixCaching : default);
                        var __StandardArgsSpecified = CliRuntime.WasSpecified(parseResult, StandardArgsOptions.MaxContextSize) || CliRuntime.WasSpecified(parseResult, StandardArgsOptions.MaxConcurrentRequests) || CliRuntime.WasSpecified(parseResult, StandardArgsOptions.GpuMemoryFraction) || CliRuntime.WasSpecified(parseResult, StandardArgsOptions.MaxPrefillTokens) || CliRuntime.WasSpecified(parseResult, StandardArgsOptions.EnablePrefixCaching);
                        var standardArgs =
                            __StandardArgsSpecified || __StandardArgsBase is not null
                                ? new global::DeepInfra.StandardArgs
                                {
	                                MaxContextSize = standardArgsMaxContextSize,
                                MaxConcurrentRequests = standardArgsMaxConcurrentRequests,
                                GpuMemoryFraction = standardArgsGpuMemoryFraction,
                                MaxPrefillTokens = standardArgsMaxPrefillTokens,
                                EnablePrefixCaching = standardArgsEnablePrefixCaching,

                                }
                                : __StandardArgsBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DedicatedModels.DeployUpdateAsync(
                                    deployId: deployId,
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    extraArgs: extraArgs,
                                    settings: settings,
                                    standardArgs: standardArgs,
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