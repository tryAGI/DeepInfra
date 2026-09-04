#nullable enable

namespace DeepInfra
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Request Gpu Pool Change<br/>
        /// File or amend the caller's single open GPU limit request.
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.GpuPoolPendingRequestOut> RequestGpuPoolChangeAsync(

            global::DeepInfra.GpuPoolRequestIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Gpu Pool Change<br/>
        /// File or amend the caller's single open GPU limit request.
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.GpuPoolPendingRequestOut>> RequestGpuPoolChangeAsResponseAsync(

            global::DeepInfra.GpuPoolRequestIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Gpu Pool Change<br/>
        /// File or amend the caller's single open GPU limit request.
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="reason">
        /// Why you need the change. Shown to the reviewer.
        /// </param>
        /// <param name="requestedMin">
        /// Guaranteed capacity.
        /// </param>
        /// <param name="requestedMax">
        /// Desired max GPUs per type, e.g. {"H100-80GB": 16}. REPLACES the contents of your pending request, so send every entry you still want changed.
        /// </param>
        /// <param name="expectedRequestId">
        /// Id of the pending request you are editing, from GET /v1/me/gpu_pool (pending_request.id), or null if you have none.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.GpuPoolPendingRequestOut> RequestGpuPoolChangeAsync(
            string reason,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::System.Collections.Generic.Dictionary<string, int>? requestedMin = default,
            global::System.Collections.Generic.Dictionary<string, int>? requestedMax = default,
            string? expectedRequestId = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}