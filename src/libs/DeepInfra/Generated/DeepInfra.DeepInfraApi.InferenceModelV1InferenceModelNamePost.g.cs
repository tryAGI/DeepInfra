
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareInferenceModelV1InferenceModelNamePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelName,
            ref string? version,
            ref string? xDeepinfraSource,
            ref string? userAgent);
        partial void PrepareInferenceModelV1InferenceModelNamePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelName,
            string? version,
            string? xDeepinfraSource,
            string? userAgent);
        partial void ProcessInferenceModelV1InferenceModelNamePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInferenceModelV1InferenceModelNamePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Inference Model
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="version">
        /// model version to run inference against
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.InferenceModelV1InferenceModelNamePostResponse> InferenceModelV1InferenceModelNamePostAsync(
            string modelName,
            string? version = default,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareInferenceModelV1InferenceModelNamePostArguments(
                httpClient: _httpClient,
                modelName: ref modelName,
                version: ref version,
                xDeepinfraSource: ref xDeepinfraSource,
                userAgent: ref userAgent);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/inference/{modelName}?version={version}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareInferenceModelV1InferenceModelNamePostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                modelName: modelName,
                version: version,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessInferenceModelV1InferenceModelNamePostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessInferenceModelV1InferenceModelNamePostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.InferenceModelV1InferenceModelNamePostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}