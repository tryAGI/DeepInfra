#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Openai Images Generations<br/>
        /// Generate image using OpenAI Images API
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenAIImagesOut> OpenaiImagesGenerations2Async(
            global::DeepInfra.OpenAIImagesGenerationsIn request,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Images Generations<br/>
        /// Generate image using OpenAI Images API
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="model">
        /// The model to use for image generation.<br/>
        /// Example: black-forest-labs/FLUX-1-schnell
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
        /// <param name="prompt">
        /// A text description of desired image(s).<br/>
        /// Example: A photo of an astronaut riding a horse on Mars.
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated.
        /// </param>
        /// <param name="style">
        /// The style of the generated images.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenAIImagesOut> OpenaiImagesGenerations2Async(
            string model,
            string prompt,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            int? n = default,
            global::DeepInfra.OpenAIImagesResponseFormat? responseFormat = default,
            string? size = default,
            string? user = default,
            string? quality = default,
            string? style = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}