#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Anthropic Messages Count Tokens
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AnthropicMessagesCountTokensAsync(
            global::DeepInfra.AnthropicTokenCountRequest request,
            string? authorization = default,
            string? xApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Anthropic Messages Count Tokens
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="xApiKey"></param>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="system"></param>
        /// <param name="tools"></param>
        /// <param name="thinking"></param>
        /// <param name="toolChoice"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AnthropicMessagesCountTokensAsync(
            string model,
            global::System.Collections.Generic.IList<object> messages,
            string? authorization = default,
            string? xApiKey = default,
            global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>>? system = default,
            global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>? tools = default,
            global::DeepInfra.AnthropicThinkingConfig? thinking = default,
            object? toolChoice = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}