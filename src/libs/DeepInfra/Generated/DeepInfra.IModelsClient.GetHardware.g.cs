#nullable enable

namespace DeepInfra
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get Hardware
        /// </summary>
        /// <param name="model">
        /// Model name (NVIDIA NemoClaw format)
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.HardwareResponse> GetHardwareAsync(
            string model,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}