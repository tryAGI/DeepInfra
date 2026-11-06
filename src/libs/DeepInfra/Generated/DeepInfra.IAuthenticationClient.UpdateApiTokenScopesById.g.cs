#nullable enable

namespace DeepInfra
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Update Api Token Scopes By Id<br/>
        /// Replace an API token's scopes, by token_id.<br/>
        /// token_id comes from Get Api Tokens (`GET /v1/api-tokens`).
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ApiToken> UpdateApiTokenScopesByIdAsync(
            string tokenId,

            global::DeepInfra.ApiTokenScopesIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Api Token Scopes By Id<br/>
        /// Replace an API token's scopes, by token_id.<br/>
        /// token_id comes from Get Api Tokens (`GET /v1/api-tokens`).
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.ApiToken>> UpdateApiTokenScopesByIdAsResponseAsync(
            string tokenId,

            global::DeepInfra.ApiTokenScopesIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Api Token Scopes By Id<br/>
        /// Replace an API token's scopes, by token_id.<br/>
        /// token_id comes from Get Api Tokens (`GET /v1/api-tokens`).
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="scopes">
        /// what the key may do: at least one scope, or `unrestricted` alone for every scope
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ApiToken> UpdateApiTokenScopesByIdAsync(
            string tokenId,
            global::System.Collections.Generic.IList<global::DeepInfra.Scope> scopes,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}