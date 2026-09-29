
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesIn
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
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>> Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, object>>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ResponsesInToolChoiceEnum?, global::DeepInfra.ResponsesFunctionToolChoice, object, object>))]
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesInToolChoiceEnum?, global::DeepInfra.ResponsesFunctionToolChoice, object, object>? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::DeepInfra.ResponsesTextConfig? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::DeepInfra.ResponsesReasoningConfig? Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        ///
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
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        public global::DeepInfra.ResponsesInTruncation? Truncation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public object? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public object? Conversation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_p")]
        public double? MinP { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_token_ids")]
        public global::System.Collections.Generic.IList<int>? StopTokenIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_template_kwargs")]
        public object? ChatTemplateKwargs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_final_message")]
        public bool? ContinueFinalMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_eos")]
        public bool? IgnoreEos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_options")]
        public global::DeepInfra.PromptCacheOptions? PromptCacheOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesIn" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input"></param>
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
        /// <param name="instructions"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="text"></param>
        /// <param name="reasoning"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="maxToolCalls"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="metadata"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="user"></param>
        /// <param name="store">
        /// Default Value: false
        /// </param>
        /// <param name="previousResponseId"></param>
        /// <param name="background">
        /// Default Value: false
        /// </param>
        /// <param name="include"></param>
        /// <param name="truncation"></param>
        /// <param name="prompt"></param>
        /// <param name="conversation"></param>
        /// <param name="minP"></param>
        /// <param name="topK"></param>
        /// <param name="repetitionPenalty"></param>
        /// <param name="stopTokenIds"></param>
        /// <param name="chatTemplateKwargs"></param>
        /// <param name="continueFinalMessage"></param>
        /// <param name="ignoreEos"></param>
        /// <param name="promptCacheKey"></param>
        /// <param name="promptCacheOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesIn(
            string model,
            global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>> input,
            global::DeepInfra.ServiceTier? serviceTier,
            bool? failFast,
            global::System.Collections.Generic.IList<string>? models,
            string? instructions,
            global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, object>>? tools,
            global::DeepInfra.AnyOf<global::DeepInfra.ResponsesInToolChoiceEnum?, global::DeepInfra.ResponsesFunctionToolChoice, object, object>? toolChoice,
            global::DeepInfra.ResponsesTextConfig? text,
            global::DeepInfra.ResponsesReasoningConfig? reasoning,
            int? maxOutputTokens,
            int? maxToolCalls,
            double? temperature,
            double? topP,
            int? topLogprobs,
            object? metadata,
            bool? parallelToolCalls,
            bool? stream,
            string? user,
            bool? store,
            string? previousResponseId,
            bool? background,
            global::System.Collections.Generic.IList<string>? include,
            global::DeepInfra.ResponsesInTruncation? truncation,
            object? prompt,
            object? conversation,
            double? minP,
            int? topK,
            double? repetitionPenalty,
            global::System.Collections.Generic.IList<int>? stopTokenIds,
            object? chatTemplateKwargs,
            bool? continueFinalMessage,
            bool? ignoreEos,
            string? promptCacheKey,
            global::DeepInfra.PromptCacheOptions? promptCacheOptions)
        {
            this.ServiceTier = serviceTier;
            this.FailFast = failFast;
            this.Models = models;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Instructions = instructions;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Text = text;
            this.Reasoning = reasoning;
            this.MaxOutputTokens = maxOutputTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopLogprobs = topLogprobs;
            this.Metadata = metadata;
            this.ParallelToolCalls = parallelToolCalls;
            this.Stream = stream;
            this.User = user;
            this.Store = store;
            this.PreviousResponseId = previousResponseId;
            this.Background = background;
            this.Include = include;
            this.Truncation = truncation;
            this.Prompt = prompt;
            this.Conversation = conversation;
            this.MinP = minP;
            this.TopK = topK;
            this.RepetitionPenalty = repetitionPenalty;
            this.StopTokenIds = stopTokenIds;
            this.ChatTemplateKwargs = chatTemplateKwargs;
            this.ContinueFinalMessage = continueFinalMessage;
            this.IgnoreEos = ignoreEos;
            this.PromptCacheKey = promptCacheKey;
            this.PromptCacheOptions = promptCacheOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesIn" /> class.
        /// </summary>
        public ResponsesIn()
        {
        }

    }
}