
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareModelMetaUpdateModelsModelNameMetaPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelName,
            global::DeepInfra.ModelMetaIn request);
        partial void PrepareModelMetaUpdateModelsModelNameMetaPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelName,
            global::DeepInfra.ModelMetaIn request);
        partial void ProcessModelMetaUpdateModelsModelNameMetaPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelMetaUpdateModelsModelNameMetaPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Model Meta Update
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.ModelMetaUpdateModelsModelNameMetaPostResponse> ModelMetaUpdateModelsModelNameMetaPostAsync(
            string modelName,
            global::DeepInfra.ModelMetaIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareModelMetaUpdateModelsModelNameMetaPostArguments(
                httpClient: _httpClient,
                modelName: ref modelName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/models/{modelName}/meta", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.ModelMetaIn);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareModelMetaUpdateModelsModelNameMetaPostRequest(
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
            ProcessModelMetaUpdateModelsModelNameMetaPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessModelMetaUpdateModelsModelNameMetaPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.ModelMetaUpdateModelsModelNameMetaPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Model Meta Update
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="description">
        /// short model description in plain text
        /// </param>
        /// <param name="githubUrl">
        /// source code project link (empty to delete)
        /// </param>
        /// <param name="paperUrl">
        /// paper/research link (empty to delete)
        /// </param>
        /// <param name="licenseUrl">
        /// usage license link (empty to delete)
        /// </param>
        /// <param name="readme">
        /// markdown flavored model readme
        /// </param>
        /// <param name="coverImgUrl">
        /// dataurl or regular url to cover image (empty to delete)
        /// </param>
        /// <param name="reportedType">
        /// model type
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.ModelMetaUpdateModelsModelNameMetaPostResponse> ModelMetaUpdateModelsModelNameMetaPostAsync(
            string modelName,
            string? description = default,
            string? githubUrl = default,
            string? paperUrl = default,
            string? licenseUrl = default,
            string? readme = default,
            string? coverImgUrl = default,
            global::System.AllOf<global::DeepInfra.HFTasksE?>? reportedType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.ModelMetaIn
            {
                Description = description,
                GithubUrl = githubUrl,
                PaperUrl = paperUrl,
                LicenseUrl = licenseUrl,
                Readme = readme,
                CoverImgUrl = coverImgUrl,
                ReportedType = reportedType,
            };

            return await ModelMetaUpdateModelsModelNameMetaPostAsync(
                modelName: modelName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}