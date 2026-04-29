#nullable enable

namespace DeepInfra
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Openai Models
        /// </summary>
        /// <param name="sortBy"></param>
        /// <param name="filter"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenAIModelsOut> OpenaiModelsAsync(
            string? sortBy = default,
            string? filter = default,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}