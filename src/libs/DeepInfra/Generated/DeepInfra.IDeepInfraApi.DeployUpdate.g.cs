#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Deploy Update
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployStatusOut> DeployUpdateAsync(
            string deployId,
            global::DeepInfra.DeployLLMUpdateIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deploy Update
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="settings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployStatusOut> DeployUpdateAsync(
            string deployId,
            global::DeepInfra.ScaleSettings settings,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}