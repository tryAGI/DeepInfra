#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Openrouter Models
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenRouterModelsOut> OpenrouterModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}