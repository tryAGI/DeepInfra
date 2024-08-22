
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareOpenaiChatCompletionsV1OpenaiChatCompletionsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool useCache,
            ref string? xDeepinfraSource,
            ref string? userAgent,
            global::DeepInfra.OpenAIChatCompletionsIn request);
        partial void PrepareOpenaiChatCompletionsV1OpenaiChatCompletionsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool useCache,
            string? xDeepinfraSource,
            string? userAgent,
            global::DeepInfra.OpenAIChatCompletionsIn request);
        partial void ProcessOpenaiChatCompletionsV1OpenaiChatCompletionsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenaiChatCompletionsV1OpenaiChatCompletionsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Openai Chat Completions
        /// </summary>
        /// <param name="useCache">
        /// Default Value: true
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.OpenaiChatCompletionsV1OpenaiChatCompletionsPostResponse> OpenaiChatCompletionsV1OpenaiChatCompletionsPostAsync(
            bool useCache,
            string? xDeepinfraSource,
            string? userAgent,
            global::DeepInfra.OpenAIChatCompletionsIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOpenaiChatCompletionsV1OpenaiChatCompletionsPostArguments(
                httpClient: _httpClient,
                useCache: ref useCache,
                xDeepinfraSource: ref xDeepinfraSource,
                userAgent: ref userAgent,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/openai/chat/completions?use_cache={useCache}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.OpenAIChatCompletionsIn);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOpenaiChatCompletionsV1OpenaiChatCompletionsPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                useCache: useCache,
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
            ProcessOpenaiChatCompletionsV1OpenaiChatCompletionsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOpenaiChatCompletionsV1OpenaiChatCompletionsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.OpenaiChatCompletionsV1OpenaiChatCompletionsPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Openai Chat Completions
        /// </summary>
        /// <param name="useCache">
        /// Default Value: true
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="model">
        /// model name<br/>
        /// Example: meta-llama/Llama-2-70b-chat-hf
        /// </param>
        /// <param name="messages">
        /// conversation messages: (user,assistant,tool)*,user including one system message anywhere
        /// </param>
        /// <param name="stream">
        /// whether to stream the output via SSE or return the full response<br/>
        /// Default Value: false
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
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the chat completion.<br/>
        /// The total length of input tokens and generated tokens is limited by the model's context length.If explicitly set to None it will be the model's max context length minus input length.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="stop">
        /// up to 16 sequences where the API will stop generating further tokens
        /// </param>
        /// <param name="n">
        /// number of sequences to return. n != 1 incompatible with streaming<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="presencePenalty">
        /// Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="frequencyPenalty">
        /// Positive values penalize new tokens based on how many times they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) function is called by the model. none means the model will not call a function and instead generates a message. auto means the model can pick between generating a message or calling a function. specifying a particular function choice is not supported currently.none is the default when no functions are present. auto is the default if functions are present.
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
        public async global::System.Threading.Tasks.Task<global::DeepInfra.OpenaiChatCompletionsV1OpenaiChatCompletionsPostResponse> OpenaiChatCompletionsV1OpenaiChatCompletionsPostAsync(
            string model,
            global::System.Collections.Generic.IList<global::System.AnyOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>> messages,
            bool useCache = true,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            bool stream = false,
            double temperature = 1,
            double topP = 1,
            int topK = 0,
            int maxTokens = 512,
            global::System.AnyOf<string?, global::System.Collections.Generic.IList<string>>? stop = default,
            int n = 1,
            double presencePenalty = 0,
            double frequencyPenalty = 0,
            global::System.Collections.Generic.IList<global::DeepInfra.ChatTools>? tools = default,
            string? toolChoice = default,
            global::System.AllOf<global::DeepInfra.ResponseFormat4>? responseFormat = default,
            double repetitionPenalty = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.OpenAIChatCompletionsIn
            {
                Model = model,
                Messages = messages,
                Stream = stream,
                Temperature = temperature,
                TopP = topP,
                TopK = topK,
                MaxTokens = maxTokens,
                Stop = stop,
                N = n,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                Tools = tools,
                ToolChoice = toolChoice,
                ResponseFormat = responseFormat,
                RepetitionPenalty = repetitionPenalty,
            };

            return await OpenaiChatCompletionsV1OpenaiChatCompletionsPostAsync(
                useCache: useCache,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}