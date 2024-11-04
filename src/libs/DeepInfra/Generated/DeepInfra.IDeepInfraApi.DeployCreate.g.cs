#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Deploy Create
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployResult> DeployCreateAsync(
            global::DeepInfra.DeployModelIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deploy Create
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="provider">
        /// namespace for the model name
        /// </param>
        /// <param name="modelName">
        /// model name in specified provider
        /// </param>
        /// <param name="version">
        /// A specific revision, if left empty uses the last one
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployResult> DeployCreateAsync(
            string modelName,
            string? xiApiKey = default,
            global::DeepInfra.ModelProvider? provider = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}