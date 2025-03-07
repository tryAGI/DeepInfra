#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Deploy Status
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeploymentOut> DeployStatusAsync(
            string deployId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}