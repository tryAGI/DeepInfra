#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Get Hardware
        /// </summary>
        /// <param name="model">
        /// Model name (NVIDIA NemoClaw format)
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.HardwareResponse> GetHardwareAsync(
            string model,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}