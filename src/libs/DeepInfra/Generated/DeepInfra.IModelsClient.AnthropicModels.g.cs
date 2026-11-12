#nullable enable

namespace DeepInfra
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Anthropic Models
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="afterId"></param>
        /// <param name="beforeId"></param>
        /// <param name="xDeepinfraServiceTier">
        /// Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AnthropicModelsOut> AnthropicModelsAsync(
            int? limit = default,
            string? afterId = default,
            string? beforeId = default,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Anthropic Models
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="afterId"></param>
        /// <param name="beforeId"></param>
        /// <param name="xDeepinfraServiceTier">
        /// Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.AnthropicModelsOut>> AnthropicModelsAsResponseAsync(
            int? limit = default,
            string? afterId = default,
            string? beforeId = default,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}