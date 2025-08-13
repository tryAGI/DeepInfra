
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricingPageEntryOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShortName { get; set; }

        /// <summary>
        /// The maximum context size of this model, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength> Pricing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPageEntryOut" /> class.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="shortName"></param>
        /// <param name="maxTokens">
        /// The maximum context size of this model, if applicable
        /// </param>
        /// <param name="pricing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingPageEntryOut(
            string modelName,
            string shortName,
            global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength> pricing,
            int? maxTokens)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.ShortName = shortName ?? throw new global::System.ArgumentNullException(nameof(shortName));
            this.Pricing = pricing;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPageEntryOut" /> class.
        /// </summary>
        public PricingPageEntryOut()
        {
        }
    }
}