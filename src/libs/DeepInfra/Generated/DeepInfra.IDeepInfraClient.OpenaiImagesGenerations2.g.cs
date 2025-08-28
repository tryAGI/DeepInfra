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
            global::DeepInfra.BodyOpenaiImagesGenerationsV1OpenaiImagesGenerationsPost request,
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
        /// <param name="inp"></param>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.OpenAIImagesOut> OpenaiImagesGenerations2Async(
            string prompt,
            string model,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::DeepInfra.OpenAIImagesGenerationsIn? inp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}