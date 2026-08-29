
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicMessagesIn
    {
        /// <summary>
        /// The service tier used for processing the request. 'priority' processes the request with higher priority (premium rate); 'flex' processes it at lower priority for a discount, served only when spare capacity exists and may be retried/timed out under load. Both apply only to models that support the respective tier. For compatibility, 'auto' is treated as 'priority' and 'standard_only' as 'default'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::DeepInfra.ServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// If true, the request is rejected immediately with HTTP 429 when the model has no spare capacity, instead of waiting in the queue. Opt-in; the default (false) keeps standard queueing behavior.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_fast")]
        public bool? FailFast { get; set; }

        /// <summary>
        /// Ordered list of up to 4 fallback models. The request is attempted on each model in order: when a model rejects it for lack of capacity (HTTP 429 model-busy / flex no-capacity), the next model is tried server-side. The first model that accepts serves the request; the response's model field and billing reflect that model, at that model's pricing. Models before the last are attempted without queueing (as if fail_fast were set); the last model honors the request's own fail_fast value. When models is set, the model field is ignored. Entries must be plain model names (no deploy_id:, custom_hostport, or :revision specifiers); duplicate entries are ignored, keeping the first occurrence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Messages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>))]
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>? System { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public object? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::DeepInfra.AnthropicThinkingConfig? Thinking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessagesIn" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
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
        /// <param name="maxTokens"></param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessagesIn(
            string model,
            global::System.Collections.Generic.IList<object> messages,
            global::DeepInfra.ServiceTier? serviceTier,
            bool? failFast,
            global::System.Collections.Generic.IList<string>? models,
            int? maxTokens,
            global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>? system,
            global::System.Collections.Generic.IList<string>? stopSequences,
            bool? stream,
            double? temperature,
            double? topP,
            int? topK,
            object? metadata,
            global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>? tools,
            object? toolChoice,
            global::DeepInfra.AnthropicThinkingConfig? thinking,
            string? promptCacheKey)
        {
            this.ServiceTier = serviceTier;
            this.FailFast = failFast;
            this.Models = models;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxTokens = maxTokens;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.System = system;
            this.StopSequences = stopSequences;
            this.Stream = stream;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.Metadata = metadata;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Thinking = thinking;
            this.PromptCacheKey = promptCacheKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessagesIn" /> class.
        /// </summary>
        public AnthropicMessagesIn()
        {
        }

    }
}