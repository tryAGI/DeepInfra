#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Openai Embeddings
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiEmbeddingsAsync(

            global::DeepInfra.OpenAIEmbeddingsIn request,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Embeddings
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="serviceTier">
        /// The service tier used for processing the request. When set to 'priority', the request will be processed with higher priority (only applies to models that support it).
        /// </param>
        /// <param name="model">
        /// model name
        /// </param>
        /// <param name="input">
        /// sequences to embed
        /// </param>
        /// <param name="encodingFormat">
        /// format used when encoding<br/>
        /// Default Value: float
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions in the embedding. If not provided, the model's default will be used.If provided bigger than model's default, the embedding will be padded with zeros.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiEmbeddingsAsync(
            string model,
            global::DeepInfra.AnyOf<global::System.Collections.Generic.IList<string>, string> input,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::DeepInfra.ServiceTier? serviceTier = default,
            global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? encodingFormat = default,
            int? dimensions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}