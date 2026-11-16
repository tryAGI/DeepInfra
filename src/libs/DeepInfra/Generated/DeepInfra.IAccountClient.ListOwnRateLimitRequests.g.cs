#nullable enable

namespace DeepInfra
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// List Own Rate Limit Requests<br/>
        /// The account's own rate limit requests, newest first, each with how it<br/>
        /// ended, and whether a new one would be accepted. A team member reads the team's.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.CustomerRateLimitRequestsOut> ListOwnRateLimitRequestsAsync(
            int? limit = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Own Rate Limit Requests<br/>
        /// The account's own rate limit requests, newest first, each with how it<br/>
        /// ended, and whether a new one would be accepted. A team member reads the team's.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.CustomerRateLimitRequestsOut>> ListOwnRateLimitRequestsAsResponseAsync(
            int? limit = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}