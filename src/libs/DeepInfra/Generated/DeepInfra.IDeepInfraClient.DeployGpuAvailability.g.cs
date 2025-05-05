#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Deploy Gpu Availability
        /// </summary>
        /// <param name="source"></param>
        /// <param name="baseModel"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployGPUAvailability> DeployGpuAvailabilityAsync(
            string? source = default,
            string? baseModel = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}