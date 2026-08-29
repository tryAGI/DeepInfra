#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class DedicatedModelsDeployRebalanceCommandApiCommand
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

    private static Option<string> TargetDeployId { get; } = new(
        name: @"--target-deploy-id")
    {
        Description = @"Deployment to grow using GPUs freed from this one.",
        Required = true,
    };

    private static Option<int> Count { get; } = new(
        name: @"--count")
    {
        Description = @"Number of target instances to create.",
        Required = true,
    };

    private static Option<bool?> DryRun { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--dry-run",
        description: @"Validate and preview without moving anything.");
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

                    private static string FormatResponse(ParseResult parseResult, global::DeepInfra.RebalanceOut value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::DeepInfra.RebalanceOut value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"deploy-rebalance", @"Deploy Rebalance
Start a GPU pool rebalance: move GPUs from this deployment onto another
deployment you own, one instance at a time and without downtime. Moving all
instances stops this deployment; start it again later to resume it.");
                        command.Arguments.Add(DeployId);
                        command.Options.Add(XiApiKey);
                        command.Options.Add(XApiKey);
                        command.Options.Add(TargetDeployId);
                        command.Options.Add(Count);
                        command.Options.Add(DryRun);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::DeepInfra.RebalanceIn>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::DeepInfra.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var deployId = parseResult.GetRequiredValue(DeployId);
                        var xiApiKey = parseResult.GetValue(XiApiKey);
                        var xApiKey = parseResult.GetValue(XApiKey);
                        var targetDeployId = parseResult.GetRequiredValue(TargetDeployId);
                        var count = parseResult.GetRequiredValue(Count);
                        var dryRun = CliRuntime.WasSpecified(parseResult, DryRun) ? parseResult.GetValue(DryRun) : (__requestBase is { } __DryRunBaseValue ? __DryRunBaseValue.DryRun : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DedicatedModels.DeployRebalanceAsync(
                                    deployId: deployId,
                                    xiApiKey: xiApiKey,
                                    xApiKey: xApiKey,
                                    targetDeployId: targetDeployId,
                                    count: count,
                                    dryRun: dryRun,
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