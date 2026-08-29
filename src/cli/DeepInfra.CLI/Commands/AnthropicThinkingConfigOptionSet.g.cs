#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record AnthropicThinkingConfigOptionSet(
    Option<int?> BudgetTokens,
                     Option<bool?> Enabled)
{
    public static AnthropicThinkingConfigOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new AnthropicThinkingConfigOptionSet(
                        BudgetTokens: new Option<int?>($"--{normalizedPrefix}budget-tokens")
                {
                    Description = @"",
                },
                Enabled: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}enabled", description: @"")
        );
    }
}