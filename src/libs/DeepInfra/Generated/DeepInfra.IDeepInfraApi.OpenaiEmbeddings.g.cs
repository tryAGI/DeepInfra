#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Openai Embeddings
        /// </summary>
        /// <param name="useCache">
        /// Default Value: true
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiEmbeddingsAsync(
            global::DeepInfra.OpenAIEmbeddingsIn request,
            bool? useCache = true,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Embeddings
        /// </summary>
        /// <param name="useCache">
        /// Default Value: true
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="model">
        /// model name<br/>
        /// Example: thenlper/gte-large
        /// </param>
        /// <param name="input">
        /// sequences to embed<br/>
        /// Example: [I like chocolate]
        /// </param>
        /// <param name="encodingFormat">
        /// format used when encoding<br/>
        /// Default Value: float
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiEmbeddingsAsync(
            string model,
            global::DeepInfra.AnyOf<global::System.Collections.Generic.IList<string>, string> input,
            bool? useCache = true,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? encodingFormat = global::DeepInfra.OpenAIEmbeddingsInEncodingFormat.Float,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}