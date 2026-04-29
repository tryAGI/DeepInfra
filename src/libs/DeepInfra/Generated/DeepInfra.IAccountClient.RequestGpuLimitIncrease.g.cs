#nullable enable

namespace DeepInfra
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Request Gpu Limit Increase
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RequestGpuLimitIncreaseAsync(

            global::DeepInfra.GpuLimitRequestIn request,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Gpu Limit Increase
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="gpuType"></param>
        /// <param name="requestedLimit"></param>
        /// <param name="reason"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RequestGpuLimitIncreaseAsync(
            string gpuType,
            int requestedLimit,
            string reason,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}