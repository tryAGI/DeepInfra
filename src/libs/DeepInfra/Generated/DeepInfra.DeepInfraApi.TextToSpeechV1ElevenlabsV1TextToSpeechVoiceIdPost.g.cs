
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareTextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            ref string? xDeepinfraSource,
            global::DeepInfra.ElevenLabsTextToSpeechIn request);
        partial void PrepareTextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            string? xDeepinfraSource,
            global::DeepInfra.ElevenLabsTextToSpeechIn request);
        partial void ProcessTextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text To Speech
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.TextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostResponse> TextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostAsync(
            string voiceId,
            global::DeepInfra.ElevenLabsTextToSpeechIn request,
            string? xDeepinfraSource = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareTextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostArguments(
                httpClient: _httpClient,
                voiceId: ref voiceId,
                xDeepinfraSource: ref xDeepinfraSource,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/elevenlabs/v1/text-to-speech/{voiceId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.ElevenLabsTextToSpeechIn);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                voiceId: voiceId,
                xDeepinfraSource: xDeepinfraSource,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.TextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Text To Speech
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="text">
        /// Text to convert to speech<br/>
        /// Example: I'm beginnin' to feel like a Rap God, Rap God<br/>
        /// All my people from the front to the back nod, back nod<br/>
        /// Now, who thinks their arms are long enough to slap box, slap box?<br/>
        /// They said I rap like a robot, so call me Rap-bot
        /// </param>
        /// <param name="modelId">
        /// Model ID to use for the conversion<br/>
        /// Default Value: deepinfra/tts
        /// </param>
        /// <param name="outputFormat">
        /// Output format for the speech<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="languageCode">
        /// ISO 639-1, 2 letter language code
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.TextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostResponse> TextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostAsync(
            string voiceId,
            string text,
            string? xDeepinfraSource = default,
            string? modelId = "deepinfra/tts",
            global::System.AllOf<global::DeepInfra.TtsResponseFormat?>? outputFormat = default,
            string? languageCode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.ElevenLabsTextToSpeechIn
            {
                Text = text,
                ModelId = modelId,
                OutputFormat = outputFormat,
                LanguageCode = languageCode,
            };

            return await TextToSpeechV1ElevenlabsV1TextToSpeechVoiceIdPostAsync(
                voiceId: voiceId,
                xDeepinfraSource: xDeepinfraSource,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}