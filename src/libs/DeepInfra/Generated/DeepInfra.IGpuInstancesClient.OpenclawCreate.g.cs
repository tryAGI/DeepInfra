#nullable enable

namespace DeepInfra
{
    public partial interface IGpuInstancesClient
    {
        /// <summary>
        /// Openclaw Create
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenClawCreateOut> OpenclawCreateAsync(

            global::DeepInfra.OpenClawCreateIn request,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openclaw Create
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name">
        /// Instance name
        /// </param>
        /// <param name="dataDiskSizeGb">
        /// Data disk size in GB. Can be expanded later.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="region">
        /// AWS region<br/>
        /// Default Value: us-west-2
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenClawCreateOut> OpenclawCreateAsync(
            string name,
            string? xiApiKey = default,
            int? dataDiskSizeGb = default,
            string? region = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}