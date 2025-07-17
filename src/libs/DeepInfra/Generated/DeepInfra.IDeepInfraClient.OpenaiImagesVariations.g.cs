#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Openai Images Variations<br/>
        /// Generate a similar image using OpenAI Images Variations API
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenAIImagesOut> OpenaiImagesVariationsAsync(
            global::DeepInfra.OpenAIImagesVariationsIn request,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Images Variations<br/>
        /// Generate a similar image using OpenAI Images Variations API
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="model">
        /// The model to use.
        /// </param>
        /// <param name="n">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="size">
        /// The size of the generated images. Available sizes depend on the model.<br/>
        /// Default Value: 1024x1024
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help to monitor and detect abuse.
        /// </param>
        /// <param name="image">
        /// Input image bytes for variation task
        /// </param>
        /// <param name="imagename">
        /// Input image bytes for variation task
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenAIImagesOut> OpenaiImagesVariationsAsync(
            string model,
            byte[] image,
            string imagename,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            int? n = default,
            global::DeepInfra.OpenAIImagesResponseFormat? responseFormat = default,
            string? size = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}