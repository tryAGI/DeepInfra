
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareOpenaiCompletionsV1OpenaiCompletionsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xDeepinfraSource,
            ref string? userAgent,
            global::DeepInfra.OpenAICompletionsIn request);
        partial void PrepareOpenaiCompletionsV1OpenaiCompletionsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xDeepinfraSource,
            string? userAgent,
            global::DeepInfra.OpenAICompletionsIn request);
        partial void ProcessOpenaiCompletionsV1OpenaiCompletionsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenaiCompletionsV1OpenaiCompletionsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Openai Completions
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.OpenaiCompletionsV1OpenaiCompletionsPostResponse> OpenaiCompletionsV1OpenaiCompletionsPostAsync(
            string? xDeepinfraSource,
            string? userAgent,
            global::DeepInfra.OpenAICompletionsIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOpenaiCompletionsV1OpenaiCompletionsPostArguments(
                httpClient: _httpClient,
                xDeepinfraSource: ref xDeepinfraSource,
                userAgent: ref userAgent,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/openai/completions", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.OpenAICompletionsIn),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOpenaiCompletionsV1OpenaiCompletionsPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOpenaiCompletionsV1OpenaiCompletionsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOpenaiCompletionsV1OpenaiCompletionsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.OpenaiCompletionsV1OpenaiCompletionsPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Openai Completions
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="model">
        /// model name<br/>
        /// Example: meta-llama/Llama-2-70b-chat-hf
        /// </param>
        /// <param name="prompt">
        /// input prompt - a single string is currently supported
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion.<br/>
        /// The total length of input tokens and generated tokens is limited by the model's context length.If explicitly set to None it will be the model's max context length minus input length.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="topK">
        /// Sample from the best k (number of) tokens. 0 means off<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="n">
        /// number of sequences to return. n != 1 incompatible with streaming<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="stream">
        /// whether to stream the output via SSE or return the full response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="logprobs">
        /// return top tokens and their log-probabilities
        /// </param>
        /// <param name="echo">
        /// return prompt as part of the respons
        /// </param>
        /// <param name="stop">
        /// up to 16 sequences where the API will stop generating further tokens
        /// </param>
        /// <param name="presencePenalty">
        /// Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="frequencyPenalty">
        /// Positive values penalize new tokens based on how many times they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat">
        /// The format of the response. Currently, only json is supported.
        /// </param>
        /// <param name="repetitionPenalty">
        /// Alternative penalty for repetition, but multiplicative instead of additive (&gt; 1 penalize, &lt; 1 encourage)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.OpenaiCompletionsV1OpenaiCompletionsPostResponse> OpenaiCompletionsV1OpenaiCompletionsPostAsync(
            string model,
            string prompt,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            int maxTokens = 512,
            double temperature = 1,
            double topP = 1,
            int topK = 0,
            int n = 1,
            bool stream = false,
            int logprobs = default,
            bool echo = default,
            global::System.AnyOf<string?, global::System.Collections.Generic.IList<string>?>? stop = default,
            double presencePenalty = 0,
            double frequencyPenalty = 0,
            global::System.AllOf<global::DeepInfra.ResponseFormat4?>? responseFormat = default,
            double repetitionPenalty = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.OpenAICompletionsIn
            {
                Model = model,
                Prompt = prompt,
                MaxTokens = maxTokens,
                Temperature = temperature,
                TopP = topP,
                TopK = topK,
                N = n,
                Stream = stream,
                Logprobs = logprobs,
                Echo = echo,
                Stop = stop,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                ResponseFormat = responseFormat,
                RepetitionPenalty = repetitionPenalty,
            };

            return await OpenaiCompletionsV1OpenaiCompletionsPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}