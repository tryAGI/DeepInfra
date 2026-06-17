#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record StreamOptionsOptionSet(
    Option<bool?> IncludeUsage,
                     Option<bool?> ContinuousUsageStats)
{
    public static StreamOptionsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new StreamOptionsOptionSet(
                        IncludeUsage: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}include-usage", description: @"whether to include usage data"),
                ContinuousUsageStats: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}continuous-usage-stats", description: @"whether to include usage stats continuously with each streaming event")
        );
    }
}