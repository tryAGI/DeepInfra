#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Deploy Update
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployStatusOut> DeployUpdateAsync(
            string deployId,
            global::DeepInfra.DeployLLMUpdateIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deploy Update
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="settings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployStatusOut> DeployUpdateAsync(
            string deployId,
            global::DeepInfra.ScaleSettings settings,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}