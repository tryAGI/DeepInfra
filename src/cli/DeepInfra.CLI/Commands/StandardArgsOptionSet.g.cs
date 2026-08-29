#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal sealed record StandardArgsOptionSet(
    Option<int?> MaxContextSize,
                     Option<int?> MaxConcurrentRequests,
                     Option<double?> GpuMemoryFraction,
                     Option<int?> MaxPrefillTokens,
                     Option<bool?> EnablePrefixCaching)
{
    public static StandardArgsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new StandardArgsOptionSet(
                        MaxContextSize: new Option<int?>($"--{normalizedPrefix}max-context-size")
                {
                    Description = @"Maximum total sequence length (prompt + generation).",
                },
                MaxConcurrentRequests: new Option<int?>($"--{normalizedPrefix}max-concurrent-requests")
                {
                    Description = @"Max number of requests served concurrently.",
                },
                GpuMemoryFraction: new Option<double?>($"--{normalizedPrefix}gpu-memory-fraction")
                {
                    Description = @"Fraction of GPU memory the engine may use for weights + KV cache.",
                },
                MaxPrefillTokens: new Option<int?>($"--{normalizedPrefix}max-prefill-tokens")
                {
                    Description = @"Max tokens processed per prefill/engine step (chunked prefill size).",
                },
                EnablePrefixCaching: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}enable-prefix-caching", description: @"Reuse KV cache for shared prompt prefixes.")
        );
    }
}