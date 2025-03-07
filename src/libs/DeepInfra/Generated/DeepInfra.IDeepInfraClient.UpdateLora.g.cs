#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Update Lora
        /// </summary>
        /// <param name="loraName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateLoraAsync(
            string loraName,
            global::DeepInfra.UpdateLoraApiRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Lora
        /// </summary>
        /// <param name="loraName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="private"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateLoraAsync(
            string loraName,
            string? xiApiKey = default,
            bool? @private = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}