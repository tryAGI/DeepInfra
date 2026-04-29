#nullable enable

namespace DeepInfra
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Usage Api Token
        /// </summary>
        /// <param name="apiToken"></param>
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
        global::System.Threading.Tasks.Task<global::DeepInfra.UsageOut> UsageApiTokenAsync(
            string apiToken,
            string from,
            string? to = default,
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}