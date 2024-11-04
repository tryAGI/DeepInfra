#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Deploy Create Hf
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployResult> DeployCreateHfAsync(
            global::DeepInfra.HFModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deploy Create Hf
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="modelName">
        /// Model Id from huggingface<br/>
        /// Example: google/vit-base-patch16-224
        /// </param>
        /// <param name="task">
        /// Task<br/>
        /// Example: image-classification
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployResult> DeployCreateHfAsync(
            string modelName,
            string? xiApiKey = default,
            string? task = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}