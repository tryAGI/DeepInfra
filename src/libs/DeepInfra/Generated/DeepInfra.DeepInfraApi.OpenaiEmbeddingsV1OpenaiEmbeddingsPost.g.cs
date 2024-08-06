
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareOpenaiEmbeddingsV1OpenaiEmbeddingsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xDeepinfraSource,
            ref string userAgent,
            global::DeepInfra.OpenAIEmbeddingsIn request);
        partial void PrepareOpenaiEmbeddingsV1OpenaiEmbeddingsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xDeepinfraSource,
            string userAgent,
            global::DeepInfra.OpenAIEmbeddingsIn request);
        partial void ProcessOpenaiEmbeddingsV1OpenaiEmbeddingsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenaiEmbeddingsV1OpenaiEmbeddingsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Openai Embeddings
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> OpenaiEmbeddingsV1OpenaiEmbeddingsPostAsync(
            string xDeepinfraSource,
            string userAgent,
            global::DeepInfra.OpenAIEmbeddingsIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOpenaiEmbeddingsV1OpenaiEmbeddingsPostArguments(
                httpClient: _httpClient,
                xDeepinfraSource: ref xDeepinfraSource,
                userAgent: ref userAgent,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/openai/embeddings", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.OpenAIEmbeddingsIn),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOpenaiEmbeddingsV1OpenaiEmbeddingsPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOpenaiEmbeddingsV1OpenaiEmbeddingsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOpenaiEmbeddingsV1OpenaiEmbeddingsPostResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.Object) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Openai Embeddings
        /// </summary>
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
        public async global::System.Threading.Tasks.Task<object> OpenaiEmbeddingsV1OpenaiEmbeddingsPostAsync(
            string model,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, string> input,
            string xDeepinfraSource = default,
            string userAgent = default,
            global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? encodingFormat = global::DeepInfra.OpenAIEmbeddingsInEncodingFormat.Float,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.OpenAIEmbeddingsIn
            {
                Model = model,
                Input = input,
                EncodingFormat = encodingFormat,
            };

            return await OpenaiEmbeddingsV1OpenaiEmbeddingsPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}