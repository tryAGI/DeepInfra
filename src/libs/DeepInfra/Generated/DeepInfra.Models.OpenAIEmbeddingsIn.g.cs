
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAIEmbeddingsIn
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
        /// model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// text or multimodal content to embed. Each item is either a string, or a list of content parts ({"type":"text"} / {"type":"image_url"}) for multimodal embedding models such as nvidia/llama-nemotron-embed-vl-1b-v2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>> Input { get; set; }

        /// <summary>
        /// Role hint for asymmetric retrieval models: 'query' embeds a search query, 'passage'/'document' embeds a document. Controls the query:/passage: prefix on VL embedding models; ignored by symmetric models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        public global::DeepInfra.OpenAIEmbeddingsInInputType2? InputType { get; set; }

        /// <summary>
        /// format used when encoding<br/>
        /// Default Value: float
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInEncodingFormatJsonConverter))]
        public global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// The number of dimensions in the embedding. If not provided, the model's default will be used.If provided bigger than model's default, the embedding will be padded with zeros.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIEmbeddingsIn" /> class.
        /// </summary>
        /// <param name="model">
        /// model name
        /// </param>
        /// <param name="input">
        /// text or multimodal content to embed. Each item is either a string, or a list of content parts ({"type":"text"} / {"type":"image_url"}) for multimodal embedding models such as nvidia/llama-nemotron-embed-vl-1b-v2.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used for processing the request. 'priority' processes the request with higher priority (premium rate); 'flex' processes it at lower priority for a discount, served only when spare capacity exists and may be retried/timed out under load. Both apply only to models that support the respective tier. For compatibility, 'auto' is treated as 'priority' and 'standard_only' as 'default'.
        /// </param>
        /// <param name="failFast">
        /// If true, the request is rejected immediately with HTTP 429 when the model has no spare capacity, instead of waiting in the queue. Opt-in; the default (false) keeps standard queueing behavior.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="inputType">
        /// Role hint for asymmetric retrieval models: 'query' embeds a search query, 'passage'/'document' embeds a document. Controls the query:/passage: prefix on VL embedding models; ignored by symmetric models.
        /// </param>
        /// <param name="encodingFormat">
        /// format used when encoding<br/>
        /// Default Value: float
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions in the embedding. If not provided, the model's default will be used.If provided bigger than model's default, the embedding will be padded with zeros.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIEmbeddingsIn(
            string model,
            global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>> input,
            global::DeepInfra.ServiceTier? serviceTier,
            bool? failFast,
            global::DeepInfra.OpenAIEmbeddingsInInputType2? inputType,
            global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? encodingFormat,
            int? dimensions)
        {
            this.ServiceTier = serviceTier;
            this.FailFast = failFast;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.InputType = inputType;
            this.EncodingFormat = encodingFormat;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIEmbeddingsIn" /> class.
        /// </summary>
        public OpenAIEmbeddingsIn()
        {
        }

    }
}