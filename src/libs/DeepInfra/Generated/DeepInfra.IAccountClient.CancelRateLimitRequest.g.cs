#nullable enable

namespace DeepInfra
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Cancel Rate Limit Request<br/>
        /// Withdraw a request of the caller's account that still waits for an answer.<br/>
        /// Its filer, a team admin and the account itself may; nobody is emailed.
        /// </summary>
        /// <param name="rlRequestId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelRateLimitRequestAsync(
            string rlRequestId,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Rate Limit Request<br/>
        /// Withdraw a request of the caller's account that still waits for an answer.<br/>
        /// Its filer, a team admin and the account itself may; nobody is emailed.
        /// </summary>
        /// <param name="rlRequestId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<string>> CancelRateLimitRequestAsResponseAsync(
            string rlRequestId,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}