#nullable enable

namespace DeepInfra
{
    public partial interface IChatCompletionsClient
    {
        /// <summary>
        /// Anthropic Messages Count Tokens
        /// </summary>
        /// <param name="xDeepinfraServiceTier">
        /// Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AnthropicMessagesCountTokensAsync(

            global::DeepInfra.AnthropicTokenCountRequest request,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Anthropic Messages Count Tokens
        /// </summary>
        /// <param name="xDeepinfraServiceTier">
        /// Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<string>> AnthropicMessagesCountTokensAsResponseAsync(

            global::DeepInfra.AnthropicTokenCountRequest request,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Anthropic Messages Count Tokens
        /// </summary>
        /// <param name="xDeepinfraServiceTier">
        /// Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="system"></param>
        /// <param name="tools"></param>
        /// <param name="thinking"></param>
        /// <param name="toolChoice"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AnthropicMessagesCountTokensAsync(
            string model,
            global::System.Collections.Generic.IList<object> messages,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>? system = default,
            global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>? tools = default,
            global::DeepInfra.AnthropicThinkingConfig? thinking = default,
            object? toolChoice = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}