#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Create Lora
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateLoraAsync(
            global::DeepInfra.CreateLoraApiRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Lora
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="baseModel"></param>
        /// <param name="loraName"></param>
        /// <param name="source"></param>
        /// <param name="private"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateLoraAsync(
            string baseModel,
            string loraName,
            global::DeepInfra.SourceModel source,
            bool @private,
            string? xiApiKey = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}