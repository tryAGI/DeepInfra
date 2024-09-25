using System.Linq;

#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareOpenaiFilesV1OpenaiFilesPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool useCache,
            global::DeepInfra.BodyOpenaiFilesV1OpenaiFilesPost request);
        partial void PrepareOpenaiFilesV1OpenaiFilesPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool useCache,
            global::DeepInfra.BodyOpenaiFilesV1OpenaiFilesPost request);
        partial void ProcessOpenaiFilesV1OpenaiFilesPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenaiFilesV1OpenaiFilesPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="useCache">
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.OpenaiFilesV1OpenaiFilesPostResponse> OpenaiFilesV1OpenaiFilesPostAsync(
            global::DeepInfra.BodyOpenaiFilesV1OpenaiFilesPost request,
            bool useCache = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOpenaiFilesV1OpenaiFilesPostArguments(
                httpClient: _httpClient,
                useCache: ref useCache,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/openai/files?use_cache={useCache}", global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (useCache != true)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{useCache}"),
                    name: "use_cache");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Purpose}"),
                name: "purpose");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"[{string.Join(",", request.File.Select(x => x))}]"),
                name: "file");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOpenaiFilesV1OpenaiFilesPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                useCache: useCache,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOpenaiFilesV1OpenaiFilesPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOpenaiFilesV1OpenaiFilesPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.OpenaiFilesV1OpenaiFilesPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="useCache">
        /// Default Value: true
        /// </param>
        /// <param name="purpose"></param>
        /// <param name="file"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.OpenaiFilesV1OpenaiFilesPostResponse> OpenaiFilesV1OpenaiFilesPostAsync(
            string purpose,
            global::System.Collections.Generic.IList<byte[]> file,
            bool useCache = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.BodyOpenaiFilesV1OpenaiFilesPost
            {
                Purpose = purpose,
                File = file,
            };

            return await OpenaiFilesV1OpenaiFilesPostAsync(
                useCache: useCache,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}