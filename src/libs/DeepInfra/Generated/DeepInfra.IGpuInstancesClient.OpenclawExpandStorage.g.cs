#nullable enable

namespace DeepInfra
{
    public partial interface IGpuInstancesClient
    {
        /// <summary>
        /// Openclaw Expand Storage
        /// </summary>
        /// <param name="instanceId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenclawExpandStorageAsync(
            string instanceId,

            global::DeepInfra.OpenClawExpandStorageIn request,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openclaw Expand Storage
        /// </summary>
        /// <param name="instanceId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="newSizeGb">
        /// New disk size in GB (must be larger than current)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenclawExpandStorageAsync(
            string instanceId,
            int newSizeGb,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}