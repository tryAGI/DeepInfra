
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareOpenaiAudioSpeechArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? useCache,
            ref string? xDeepinfraSource,
            global::DeepInfra.OpenAITextToSpeechIn request);
        partial void PrepareOpenaiAudioSpeechRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? useCache,
            string? xDeepinfraSource,
            global::DeepInfra.OpenAITextToSpeechIn request);
        partial void ProcessOpenaiAudioSpeechResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenaiAudioSpeechResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Openai Audio Speech
        /// </summary>
        /// <param name="useCache">
        /// Default Value: true
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.OpenaiAudioSpeechV1OpenaiAudioSpeechPostResponse> OpenaiAudioSpeechAsync(
            global::DeepInfra.OpenAITextToSpeechIn request,
            bool? useCache = true,
            string? xDeepinfraSource = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOpenaiAudioSpeechArguments(
                httpClient: _httpClient,
                useCache: ref useCache,
                xDeepinfraSource: ref xDeepinfraSource,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/openai/audio/speech",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("use_cache", useCache?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}

            if (xDeepinfraSource != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("x-deepinfra-source", xDeepinfraSource.ToString());
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
            PrepareOpenaiAudioSpeechRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                useCache: useCache,
                xDeepinfraSource: xDeepinfraSource,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOpenaiAudioSpeechResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOpenaiAudioSpeechResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::DeepInfra.OpenaiAudioSpeechV1OpenaiAudioSpeechPostResponse), JsonSerializerContext) as global::DeepInfra.OpenaiAudioSpeechV1OpenaiAudioSpeechPostResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Openai Audio Speech
        /// </summary>
        /// <param name="useCache">
        /// Default Value: true
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="model">
        /// model name<br/>
        /// Example: deepinfra/tts
        /// </param>
        /// <param name="input">
        /// Text to convert to speech<br/>
        /// Example: I'm beginnin' to feel like a Rap God, Rap God<br/>
        /// All my people from the front to the back nod, back nod<br/>
        /// Now, who thinks their arms are long enough to slap box, slap box?<br/>
        /// They said I rap like a robot, so call me Rap-bot
        /// </param>
        /// <param name="voice">
        /// Preset voices to use for the speech.
        /// </param>
        /// <param name="responseFormat">
        /// response format for the speech
        /// </param>
        /// <param name="speed">
        /// speed of the speech<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.OpenaiAudioSpeechV1OpenaiAudioSpeechPostResponse> OpenaiAudioSpeechAsync(
            string model,
            string input,
            bool? useCache = true,
            string? xDeepinfraSource = default,
            global::DeepInfra.TtsVoice? voice = default,
            global::DeepInfra.TtsResponseFormat? responseFormat = default,
            double? speed = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.OpenAITextToSpeechIn
            {
                Model = model,
                Input = input,
                Voice = voice,
                ResponseFormat = responseFormat,
                Speed = speed,
            };

            return await OpenaiAudioSpeechAsync(
                useCache: useCache,
                xDeepinfraSource: xDeepinfraSource,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}