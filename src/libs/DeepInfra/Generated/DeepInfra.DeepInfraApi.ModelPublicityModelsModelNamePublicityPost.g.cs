
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareModelPublicityModelsModelNamePublicityPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelName,
            global::DeepInfra.ModelPublicityIn request);
        partial void PrepareModelPublicityModelsModelNamePublicityPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelName,
            global::DeepInfra.ModelPublicityIn request);
        partial void ProcessModelPublicityModelsModelNamePublicityPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelPublicityModelsModelNamePublicityPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Model Publicity
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.ModelPublicityModelsModelNamePublicityPostResponse> ModelPublicityModelsModelNamePublicityPostAsync(
            string modelName,
            global::DeepInfra.ModelPublicityIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareModelPublicityModelsModelNamePublicityPostArguments(
                httpClient: _httpClient,
                modelName: ref modelName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/models/{modelName}/publicity", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.ModelPublicityIn);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareModelPublicityModelsModelNamePublicityPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                modelName: modelName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessModelPublicityModelsModelNamePublicityPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessModelPublicityModelsModelNamePublicityPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.ModelPublicityModelsModelNamePublicityPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Model Publicity
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="public">
        /// whether to make the model public of private
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.ModelPublicityModelsModelNamePublicityPostResponse> ModelPublicityModelsModelNamePublicityPostAsync(
            string modelName,
            bool @public,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.ModelPublicityIn
            {
                Public = @public,
            };

            return await ModelPublicityModelsModelNamePublicityPostAsync(
                modelName: modelName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}