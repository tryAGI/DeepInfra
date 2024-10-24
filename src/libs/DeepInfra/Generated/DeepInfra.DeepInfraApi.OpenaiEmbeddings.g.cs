
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareOpenaiEmbeddingsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? useCache,
            ref string? xDeepinfraSource,
            ref string? userAgent,
            global::DeepInfra.OpenAIEmbeddingsIn request);
        partial void PrepareOpenaiEmbeddingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? useCache,
            string? xDeepinfraSource,
            string? userAgent,
            global::DeepInfra.OpenAIEmbeddingsIn request);
        partial void ProcessOpenaiEmbeddingsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenaiEmbeddingsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<string> OpenaiEmbeddingsAsync(
            global::DeepInfra.OpenAIEmbeddingsIn request,
            bool? useCache = default,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenaiEmbeddingsArguments(
                httpClient: HttpClient,
                useCache: ref useCache,
                xDeepinfraSource: ref xDeepinfraSource,
                userAgent: ref userAgent,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/openai/embeddings",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("use_cache", useCache?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (xDeepinfraSource != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-deepinfra-source", xDeepinfraSource.ToString());
            }
            if (userAgent != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("user-agent", userAgent.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOpenaiEmbeddingsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                useCache: useCache,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenaiEmbeddingsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOpenaiEmbeddingsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return __content;
        }

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
        public async global::System.Threading.Tasks.Task<string> OpenaiEmbeddingsAsync(
            string model,
            global::DeepInfra.AnyOf<global::System.Collections.Generic.IList<string>, string> input,
            bool? useCache = default,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? encodingFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::DeepInfra.OpenAIEmbeddingsIn
            {
                Model = model,
                Input = input,
                EncodingFormat = encodingFormat,
            };

            return await OpenaiEmbeddingsAsync(
                useCache: useCache,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}