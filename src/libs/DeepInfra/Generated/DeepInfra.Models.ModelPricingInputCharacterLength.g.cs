
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingInputCharacterLength
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_input_chars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerInputChars { get; set; }

        /// <summary>
        /// Default Value: input_character_length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputCharacterLength" /> class.
        /// </summary>
        /// <param name="centsPerInputChars"></param>
        /// <param name="type">
        /// Default Value: input_character_length
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingInputCharacterLength(
            double centsPerInputChars,
            string? type)
        {
            this.CentsPerInputChars = centsPerInputChars;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputCharacterLength" /> class.
        /// </summary>
        public ModelPricingInputCharacterLength()
        {
        }
    }
}