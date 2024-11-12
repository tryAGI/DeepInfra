
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingInputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_input_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerInputToken { get; set; }

        /// <summary>
        /// Default Value: input_tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputTokens" /> class.
        /// </summary>
        /// <param name="centsPerInputToken"></param>
        /// <param name="type">
        /// Default Value: input_tokens
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelPricingInputTokens(
            double centsPerInputToken,
            string? type)
        {
            this.CentsPerInputToken = centsPerInputToken;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputTokens" /> class.
        /// </summary>
        public ModelPricingInputTokens()
        {
        }
    }
}