#nullable enable

namespace DeepInfra
{
    public partial interface IImageGenerationClient
    {
        /// <summary>
        /// Get Generated Image<br/>
        /// Serve a `response_format=url` image; unauthenticated, 404 once expired.
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetGeneratedImageAsync(
            string imageId,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Generated Image<br/>
        /// Serve a `response_format=url` image; unauthenticated, 404 once expired.
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<string>> GetGeneratedImageAsResponseAsync(
            string imageId,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}