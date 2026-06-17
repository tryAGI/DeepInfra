#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record ChatReasoningSettingsOptionSet(
    Option<bool?> Enabled)
{
    public static ChatReasoningSettingsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ChatReasoningSettingsOptionSet(
                        Enabled: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}enabled", description: @"Enable or disable reasoning with default parameters.")
        );
    }
}