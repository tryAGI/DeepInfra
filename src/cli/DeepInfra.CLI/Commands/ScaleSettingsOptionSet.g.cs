#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record ScaleSettingsOptionSet(
    Option<int?> MinInstances,
                     Option<int?> MaxInstances)
{
    public static ScaleSettingsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ScaleSettingsOptionSet(
                        MinInstances: new Option<int?>($"--{normalizedPrefix}min-instances")
                {
                    Description = @"Minimum number of model instances to run",
                },
                MaxInstances: new Option<int?>($"--{normalizedPrefix}max-instances")
                {
                    Description = @"Maximum number of model instances to run",
                }
        );
    }
}