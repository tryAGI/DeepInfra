
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareDeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId);
        partial void PrepareDeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId);
        partial void ProcessDeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteResponse> DeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteAsync(
            string voiceId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteArguments(
                httpClient: _httpClient,
                voiceId: ref voiceId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/elevenlabs/v1/voices/{voiceId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                voiceId: voiceId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.DeleteVoiceV1ElevenlabsV1VoicesVoiceIdDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}