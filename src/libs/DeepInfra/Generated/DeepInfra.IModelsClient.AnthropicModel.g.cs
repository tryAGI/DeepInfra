#nullable enable

namespace DeepInfra
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Anthropic Model
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="xDeepinfraServiceTier">
        /// Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AnthropicModelOut> AnthropicModelAsync(
            string modelId,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Anthropic Model
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="xDeepinfraServiceTier">
        /// Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.AnthropicModelOut>> AnthropicModelAsResponseAsync(
            string modelId,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}