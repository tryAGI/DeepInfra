
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
        /// <example>microsoft/resnet-50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// raw type of the model<br/>
        /// Example: image-classification
        /// </summary>
        /// <example>image-classification</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// reported type of the model<br/>
        /// Example: text-generation
        /// </summary>
        /// <example>text-generation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reported_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReportedType { get; set; }

        /// <summary>
        /// description of the model<br/>
        /// Example: ResNet-50 is a convolutional neural network that is trained on more than a million images from the ImageNet database. It is a 50-layer deep neural network.
        /// </summary>
        /// <example>ResNet-50 is a convolutional neural network that is trained on more than a million images from the ImageNet database. It is a 50-layer deep neural network.</example>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverterFactory7))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits> Pricing { get; set; }

        /// <summary>
        /// The maximum context size of this model, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaced_by")]
        public string? ReplacedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        public int? Deprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        public string? Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mmlu")]
        public double? Mmlu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        public global::System.DateTime? Expected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOut" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Model Name<br/>
        /// Example: microsoft/resnet-50
        /// </param>
        /// <param name="type">
        /// raw type of the model<br/>
        /// Example: image-classification
        /// </param>
        /// <param name="reportedType">
        /// reported type of the model<br/>
        /// Example: text-generation
        /// </param>
        /// <param name="description">
        /// description of the model<br/>
        /// Example: ResNet-50 is a convolutional neural network that is trained on more than a million images from the ImageNet database. It is a 50-layer deep neural network.
        /// </param>
        /// <param name="coverImgUrl">
        /// cover image link
        /// </param>
        /// <param name="tags">
        /// list of tags
        /// </param>
        /// <param name="pricing">
        /// The pricing type and cost for this model
        /// </param>
        /// <param name="maxTokens">
        /// The maximum context size of this model, if applicable
        /// </param>
        /// <param name="replacedBy"></param>
        /// <param name="deprecated"></param>
        /// <param name="quantization"></param>
        /// <param name="mmlu"></param>
        /// <param name="expected"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelOut(
            string modelName,
            string type,
            string reportedType,
            global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits> pricing,
            string? description,
            string? coverImgUrl,
            global::System.Collections.Generic.IList<string>? tags,
            int? maxTokens,
            string? replacedBy,
            int? deprecated,
            string? quantization,
            double? mmlu,
            global::System.DateTime? expected)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ReportedType = reportedType ?? throw new global::System.ArgumentNullException(nameof(reportedType));
            this.Pricing = pricing;
            this.Description = description;
            this.CoverImgUrl = coverImgUrl;
            this.Tags = tags;
            this.MaxTokens = maxTokens;
            this.ReplacedBy = replacedBy;
            this.Deprecated = deprecated;
            this.Quantization = quantization;
            this.Mmlu = mmlu;
            this.Expected = expected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOut" /> class.
        /// </summary>
        public ModelOut()
        {
        }
    }
}