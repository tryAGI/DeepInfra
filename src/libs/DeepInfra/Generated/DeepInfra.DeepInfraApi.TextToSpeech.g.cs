
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareTextToSpeechArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            ref string? xDeepinfraSource,
            ref string? xiApiKey,
            global::DeepInfra.ElevenLabsTextToSpeechIn request);
        partial void PrepareTextToSpeechRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            string? xDeepinfraSource,
            string? xiApiKey,
            global::DeepInfra.ElevenLabsTextToSpeechIn request);
        partial void ProcessTextToSpeechResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTextToSpeechResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text To Speech
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TextToSpeechAsync(
            string voiceId,
            global::DeepInfra.ElevenLabsTextToSpeechIn request,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareTextToSpeechArguments(
                httpClient: _httpClient,
                voiceId: ref voiceId,
                xDeepinfraSource: ref xDeepinfraSource,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/text-to-speech/{voiceId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            if (xDeepinfraSource != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("x-deepinfra-source", xDeepinfraSource.ToString());
            }
            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTextToSpeechRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                voiceId: voiceId,
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTextToSpeechResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTextToSpeechResponseContent(
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

            return __content;
        }

        /// <summary>
        /// Text To Speech
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
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
        public async global::System.Threading.Tasks.Task<string> TextToSpeechAsync(
            string voiceId,
            string text,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            string? modelId = "deepinfra/tts",
            global::DeepInfra.TtsResponseFormat? outputFormat = global::DeepInfra.TtsResponseFormat.Wav,
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

            return await TextToSpeechAsync(
                voiceId: voiceId,
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}