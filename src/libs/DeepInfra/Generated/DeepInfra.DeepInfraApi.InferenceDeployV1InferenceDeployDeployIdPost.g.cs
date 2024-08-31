
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareInferenceDeployV1InferenceDeployDeployIdPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deployId,
            ref bool useCache,
            ref string? xDeepinfraSource,
            ref string? userAgent);
        partial void PrepareInferenceDeployV1InferenceDeployDeployIdPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deployId,
            bool useCache,
            string? xDeepinfraSource,
            string? userAgent);
        partial void ProcessInferenceDeployV1InferenceDeployDeployIdPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInferenceDeployV1InferenceDeployDeployIdPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Inference Deploy
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="useCache">
        /// Default Value: true
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.InferenceDeployV1InferenceDeployDeployIdPostResponse> InferenceDeployV1InferenceDeployDeployIdPostAsync(
            string deployId,
            bool useCache = true,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareInferenceDeployV1InferenceDeployDeployIdPostArguments(
                httpClient: _httpClient,
                deployId: ref deployId,
                useCache: ref useCache,
                xDeepinfraSource: ref xDeepinfraSource,
                userAgent: ref userAgent);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/inference/deploy/{deployId}?use_cache={useCache}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareInferenceDeployV1InferenceDeployDeployIdPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                deployId: deployId,
                useCache: useCache,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessInferenceDeployV1InferenceDeployDeployIdPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessInferenceDeployV1InferenceDeployDeployIdPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.InferenceDeployV1InferenceDeployDeployIdPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}