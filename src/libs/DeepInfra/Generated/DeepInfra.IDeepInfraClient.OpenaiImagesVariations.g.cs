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
            global::DeepInfra.BodyOpenaiImagesVariationsV1ImagesVariationsPost request,
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
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="inp"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenAIImagesOut> OpenaiImagesVariationsAsync(
            byte[] image,
            string imagename,
            string model,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::DeepInfra.OpenAIImagesVariationsIn? inp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}