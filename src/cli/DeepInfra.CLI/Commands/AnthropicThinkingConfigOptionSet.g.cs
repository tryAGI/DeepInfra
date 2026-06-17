#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record AnthropicThinkingConfigOptionSet(
    Option<bool?> Enabled)
{
    public static AnthropicThinkingConfigOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AnthropicThinkingConfigOptionSet(
                        Enabled: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}enabled", description: @"")
        );
    }
}