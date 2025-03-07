#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Model Versions
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepInfra.ModelVersionOut>> ModelVersionsAsync(
            string modelName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}