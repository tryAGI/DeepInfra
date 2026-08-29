#nullable enable

namespace DeepInfra
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create Video Generation
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.VideoGenerationOut> CreateVideoGeneration2Async(

            global::DeepInfra.VideoGenerationIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Video Generation
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.VideoGenerationOut>> CreateVideoGeneration2AsResponseAsync(

            global::DeepInfra.VideoGenerationIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Video Generation
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="size"></param>
        /// <param name="seconds"></param>
        /// <param name="seed"></param>
        /// <param name="style"></param>
        /// <param name="imageUrl">
        /// First-frame image for image-to-video (i2v): an http(s) URL or a data: URI. Omit for text-to-video.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.VideoGenerationOut> CreateVideoGeneration2Async(
            string model,
            string prompt,
            string? xiApiKey = default,
            string? xApiKey = default,
            string? negativePrompt = default,
            string? aspectRatio = default,
            string? size = default,
            int? seconds = default,
            int? seed = default,
            string? style = default,
            string? imageUrl = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}