using System.Linq;

#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareCreateVoiceV1ElevenlabsV1VoicesAddPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::DeepInfra.BodyCreateVoiceV1ElevenlabsV1VoicesAddPost request);
        partial void PrepareCreateVoiceV1ElevenlabsV1VoicesAddPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::DeepInfra.BodyCreateVoiceV1ElevenlabsV1VoicesAddPost request);
        partial void ProcessCreateVoiceV1ElevenlabsV1VoicesAddPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVoiceV1ElevenlabsV1VoicesAddPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.Voice2> CreateVoiceV1ElevenlabsV1VoicesAddPostAsync(
            global::DeepInfra.BodyCreateVoiceV1ElevenlabsV1VoicesAddPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateVoiceV1ElevenlabsV1VoicesAddPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/elevenlabs/v1/voices/add", global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Name}"),
                name: "name");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Description}"),
                name: "description");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"[{string.Join(",", request.Files.Select(x => x))}]"),
                name: "files");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateVoiceV1ElevenlabsV1VoicesAddPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateVoiceV1ElevenlabsV1VoicesAddPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateVoiceV1ElevenlabsV1VoicesAddPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.Voice2) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="files"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.Voice2> CreateVoiceV1ElevenlabsV1VoicesAddPostAsync(
            string name,
            string description,
            global::System.Collections.Generic.IList<byte[]> files,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.BodyCreateVoiceV1ElevenlabsV1VoicesAddPost
            {
                Name = name,
                Description = description,
                Files = files,
            };

            return await CreateVoiceV1ElevenlabsV1VoicesAddPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}