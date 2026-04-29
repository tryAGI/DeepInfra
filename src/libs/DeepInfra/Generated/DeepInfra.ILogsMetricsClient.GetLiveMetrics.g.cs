#nullable enable

namespace DeepInfra
{
    public partial interface ILogsMetricsClient
    {
        /// <summary>
        /// Get Live Metrics<br/>
        /// Get the latest values for the Live metrics section on the web front page.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.WebLiveMetricsOut> GetLiveMetricsAsync(
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}