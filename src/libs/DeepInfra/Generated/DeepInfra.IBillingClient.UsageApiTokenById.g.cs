#nullable enable

namespace DeepInfra
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Usage Api Token By Id<br/>
        /// Usage for a single API token, by token_id.<br/>
        /// token_id comes from Get Api Tokens (`GET /v1/api-tokens`).
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="from">
        /// start of period in YYYY.MM, current(-N), unix_timestamp (in seconds, UTC) format
        /// </param>
        /// <param name="to">
        /// end of period (if missing a single month marked by from is return), same format as from
        /// </param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.UsageOut> UsageApiTokenByIdAsync(
            string tokenId,
            string from,
            string? to = default,
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Usage Api Token By Id<br/>
        /// Usage for a single API token, by token_id.<br/>
        /// token_id comes from Get Api Tokens (`GET /v1/api-tokens`).
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="from">
        /// start of period in YYYY.MM, current(-N), unix_timestamp (in seconds, UTC) format
        /// </param>
        /// <param name="to">
        /// end of period (if missing a single month marked by from is return), same format as from
        /// </param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.UsageOut>> UsageApiTokenByIdAsResponseAsync(
            string tokenId,
            string from,
            string? to = default,
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}