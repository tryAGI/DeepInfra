#nullable enable

namespace DeepInfra
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Model Schema
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="variantKey"></param>
        /// <param name="version"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.SchemaOut> ModelSchemaAsync(
            string modelName,
            global::DeepInfra.SchemaVariantKey variantKey,
            string? version = default,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}