
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelOut
    {
        /// <summary>
        /// Model Name<br/>
        /// Example: microsoft/resnet-50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// raw type of the model<br/>
        /// Example: image-classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// reported type of the model<br/>
        /// Example: text-generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reported_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReportedType { get; set; }

        /// <summary>
        /// description of the model<br/>
        /// Example: ResNet-50 is a convolutional neural network that is trained on more than a million images from the ImageNet database. It is a 50-layer deep neural network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// cover image link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_img_url")]
        public string? CoverImgUrl { get; set; }

        /// <summary>
        /// list of tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The pricing type and cost for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory6))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength> Pricing { get; set; }

        /// <summary>
        /// The maximum context size of this model, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaced_by")]
        public string? ReplacedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        public int Deprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        public string? Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        public global::System.DateTime Expected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}