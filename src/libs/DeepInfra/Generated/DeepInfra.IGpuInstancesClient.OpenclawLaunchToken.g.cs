#nullable enable

namespace DeepInfra
{
    public partial interface IGpuInstancesClient
    {
        /// <summary>
        /// Openclaw Launch Token<br/>
        /// Mint a single-use launch URL for the dashboard.<br/>
        /// Called by the launcher page right when readyz flips ready. The launch URL<br/>
        /// is used as a top-level navigation; /launch then sets the oc_auth cookie<br/>
        /// and 302s into the proxied dashboard.<br/>
        /// The user's bearer token is stashed in Redis under the token's jti and<br/>
        /// retrieved (atomic GETDEL) on /launch redeem — this keeps the bearer out of<br/>
        /// the URL and out of any signed payload while preserving the existing proxy<br/>
        /// auth flow (oc_auth cookie value = bearer token).
        /// </summary>
        /// <param name="instanceId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenClawLaunchTokenOut> OpenclawLaunchTokenAsync(
            string instanceId,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openclaw Launch Token<br/>
        /// Mint a single-use launch URL for the dashboard.<br/>
        /// Called by the launcher page right when readyz flips ready. The launch URL<br/>
        /// is used as a top-level navigation; /launch then sets the oc_auth cookie<br/>
        /// and 302s into the proxied dashboard.<br/>
        /// The user's bearer token is stashed in Redis under the token's jti and<br/>
        /// retrieved (atomic GETDEL) on /launch redeem — this keeps the bearer out of<br/>
        /// the URL and out of any signed payload while preserving the existing proxy<br/>
        /// auth flow (oc_auth cookie value = bearer token).
        /// </summary>
        /// <param name="instanceId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.OpenClawLaunchTokenOut>> OpenclawLaunchTokenAsResponseAsync(
            string instanceId,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}