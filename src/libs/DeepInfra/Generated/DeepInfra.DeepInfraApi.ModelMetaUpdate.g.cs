
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareModelMetaUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelName,
            global::DeepInfra.ModelMetaIn request);
        partial void PrepareModelMetaUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelName,
            global::DeepInfra.ModelMetaIn request);
        partial void ProcessModelMetaUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelMetaUpdateResponseContent(
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
        public async global::System.Threading.Tasks.Task<string> ModelMetaUpdateAsync(
            string modelName,
            global::DeepInfra.ModelMetaIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareModelMetaUpdateArguments(
                httpClient: HttpClient,
                modelName: ref modelName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/models/{modelName}/meta",
                baseUri: HttpClient.BaseAddress); 
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareModelMetaUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                modelName: modelName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessModelMetaUpdateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessModelMetaUpdateResponseContent(
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
        public async global::System.Threading.Tasks.Task<string> ModelMetaUpdateAsync(
            string modelName,
            string? description = default,
            string? githubUrl = default,
            string? paperUrl = default,
            string? licenseUrl = default,
            string? readme = default,
            string? coverImgUrl = default,
            global::DeepInfra.HFTasksE? reportedType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::DeepInfra.ModelMetaIn
            {
                Description = description,
                GithubUrl = githubUrl,
                PaperUrl = paperUrl,
                LicenseUrl = licenseUrl,
                Readme = readme,
                CoverImgUrl = coverImgUrl,
                ReportedType = reportedType,
            };

            return await ModelMetaUpdateAsync(
                modelName: modelName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}