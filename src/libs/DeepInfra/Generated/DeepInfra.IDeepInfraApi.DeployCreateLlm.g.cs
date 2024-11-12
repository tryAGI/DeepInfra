#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Deploy Create Llm
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeploymentOut> DeployCreateLlmAsync(
            global::DeepInfra.DeployLLMIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deploy Create Llm
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="modelName">
        /// model name for deepinfra (username/mode-name format)
        /// </param>
        /// <param name="gpu">
        /// The GPU you want to run on
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs you want for this model<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxBatchSize">
        /// Maximum number of concurrent requests<br/>
        /// Default Value: 96
        /// </param>
        /// <param name="hf"></param>
        /// <param name="settings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeploymentOut> DeployCreateLlmAsync(
            string modelName,
            global::DeepInfra.DeployGPUs gpu,
            string? xiApiKey = default,
            int? numGpus = default,
            int? maxBatchSize = default,
            global::DeepInfra.HFWeights? hf = default,
            global::DeepInfra.ScaleSettings? settings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}