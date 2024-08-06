
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareOpenaiAudioSpeechV1OpenaiAudioSpeechPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xDeepinfraSource,
            global::DeepInfra.OpenAITextToSpeechIn request);
        partial void PrepareOpenaiAudioSpeechV1OpenaiAudioSpeechPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xDeepinfraSource,
            global::DeepInfra.OpenAITextToSpeechIn request);
        partial void ProcessOpenaiAudioSpeechV1OpenaiAudioSpeechPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenaiAudioSpeechV1OpenaiAudioSpeechPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Openai Audio Speech
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> OpenaiAudioSpeechV1OpenaiAudioSpeechPostAsync(
            string xDeepinfraSource,
            global::DeepInfra.OpenAITextToSpeechIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOpenaiAudioSpeechV1OpenaiAudioSpeechPostArguments(
                httpClient: _httpClient,
                xDeepinfraSource: ref xDeepinfraSource,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/openai/audio/speech", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.OpenAITextToSpeechIn),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOpenaiAudioSpeechV1OpenaiAudioSpeechPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xDeepinfraSource: xDeepinfraSource,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOpenaiAudioSpeechV1OpenaiAudioSpeechPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOpenaiAudioSpeechV1OpenaiAudioSpeechPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.Object) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Openai Audio Speech
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="webhook">
        /// The webhook to call when inference is done, by default you will get the output in the response of your inference request
        /// </param>
        /// <param name="model">
        /// model name<br/>
        /// Example: deepinfra/tts
        /// </param>
        /// <param name="input">
        /// text to convert to speech<br/>
        /// Example: Hello, how are you?
        /// </param>
        /// <param name="voice">
        /// Preset voices to use for the speech.<br/>
        /// Default Value: luna
        /// </param>
        /// <param name="responseFormat">
        /// response format for the speech<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="speed">
        /// speed of the speech<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> OpenaiAudioSpeechV1OpenaiAudioSpeechPostAsync(
            string model,
            string input,
            string xDeepinfraSource = default,
            string? webhook = default,
            global::System.AllOf<global::DeepInfra.TtsVoice?>? voice = default,
            global::System.AllOf<global::DeepInfra.TtsResponseFormat?>? responseFormat = default,
            double speed = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.OpenAITextToSpeechIn
            {
                Webhook = webhook,
                Model = model,
                Input = input,
                Voice = voice,
                ResponseFormat = responseFormat,
                Speed = speed,
            };

            return await OpenaiAudioSpeechV1OpenaiAudioSpeechPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}