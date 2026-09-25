#nullable enable

namespace DeepInfra
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Set Key Limit
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepInfra.KeyLimitOut>> SetKeyLimitAsync(

            global::DeepInfra.KeyLimitIn request,
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Key Limit
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::DeepInfra.KeyLimitOut>>> SetKeyLimitAsResponseAsync(

            global::DeepInfra.KeyLimitIn request,
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Key Limit
        /// </summary>
        /// <param name="session"></param>
        /// <param name="tokenId">
        /// Api key id, as returned by /v1/api-tokens
        /// </param>
        /// <param name="limit">
        /// Monthly spending limit (in USD) for this key. Null or negative removes it; 0 blocks the key
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepInfra.KeyLimitOut>> SetKeyLimitAsync(
            string tokenId,
            object? session = default,
            double? limit = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}