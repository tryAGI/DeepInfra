
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareUpdateVoiceV1VoicesVoiceIdEditPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            global::DeepInfra.UpdateVoiceIn request);
        partial void PrepareUpdateVoiceV1VoicesVoiceIdEditPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            global::DeepInfra.UpdateVoiceIn request);
        partial void ProcessUpdateVoiceV1VoicesVoiceIdEditPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateVoiceV1VoicesVoiceIdEditPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.Voice2> UpdateVoiceV1VoicesVoiceIdEditPostAsync(
            string voiceId,
            global::DeepInfra.UpdateVoiceIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateVoiceV1VoicesVoiceIdEditPostArguments(
                httpClient: _httpClient,
                voiceId: ref voiceId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/voices/{voiceId}/edit", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.UpdateVoiceIn);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateVoiceV1VoicesVoiceIdEditPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                voiceId: voiceId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateVoiceV1VoicesVoiceIdEditPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateVoiceV1VoicesVoiceIdEditPostResponseContent(
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
        /// Update Voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.Voice2> UpdateVoiceV1VoicesVoiceIdEditPostAsync(
            string voiceId,
            string name,
            string description,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.UpdateVoiceIn
            {
                Name = name,
                Description = description,
            };

            return await UpdateVoiceV1VoicesVoiceIdEditPostAsync(
                voiceId: voiceId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}