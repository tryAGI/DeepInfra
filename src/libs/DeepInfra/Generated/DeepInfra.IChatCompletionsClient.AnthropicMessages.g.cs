#nullable enable

namespace DeepInfra
{
    public partial interface IChatCompletionsClient
    {
        /// <summary>
        /// Anthropic Messages
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xDeepinfraServiceTier"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AnthropicMessagesAsync(

            global::DeepInfra.AnthropicMessagesIn request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? xDeepinfraSource = default,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Anthropic Messages
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xDeepinfraServiceTier"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<string>> AnthropicMessagesAsResponseAsync(

            global::DeepInfra.AnthropicMessagesIn request,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? xDeepinfraSource = default,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Anthropic Messages
        /// </summary>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xDeepinfraServiceTier"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="serviceTier">
        /// The service tier used for processing the request. 'priority' processes the request with higher priority (premium rate); 'flex' processes it at lower priority for a discount, served only when spare capacity exists and may be retried/timed out under load. Both apply only to models that support the respective tier. For compatibility, 'auto' is treated as 'priority' and 'standard_only' as 'default'.
        /// </param>
        /// <param name="failFast">
        /// If true, the request is rejected immediately with HTTP 429 when the model has no spare capacity, instead of waiting in the queue. Opt-in; the default (false) keeps standard queueing behavior.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="models">
        /// Ordered list of up to 4 fallback models. The request is attempted on each model in order: when a model rejects it for lack of capacity (HTTP 429 model-busy / flex no-capacity), the next model is tried server-side. The first model that accepts serves the request; the response's model field and billing reflect that model, at that model's pricing. Models before the last are attempted without queueing (as if fail_fast were set); the last model honors the request's own fail_fast value. When models is set, the model field is ignored. Entries must be plain model names (no deploy_id:, custom_hostport, or :revision specifiers); duplicate entries are ignored, keeping the first occurrence.
        /// </param>
        /// <param name="model"></param>
        /// <param name="maxTokens"></param>
        /// <param name="messages"></param>
        /// <param name="system"></param>
        /// <param name="stopSequences"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// Default Value: 1F
        /// </param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        /// <param name="metadata"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="thinking"></param>
        /// <param name="promptCacheKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AnthropicMessagesAsync(
            string model,
            global::System.Collections.Generic.IList<object> messages,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? xDeepinfraSource = default,
            string? xDeepinfraServiceTier = default,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.ServiceTier? serviceTier = default,
            bool? failFast = default,
            global::System.Collections.Generic.IList<string>? models = default,
            int? maxTokens = default,
            global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>? system = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            bool? stream = default,
            double? temperature = default,
            double? topP = default,
            int? topK = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>? tools = default,
            object? toolChoice = default,
            global::DeepInfra.AnthropicThinkingConfig? thinking = default,
            string? promptCacheKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}