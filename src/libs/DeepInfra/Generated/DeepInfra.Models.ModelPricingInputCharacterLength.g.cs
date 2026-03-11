
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingInputCharacterLength
    {
        /// <summary>
        /// Short description of the pricing, ideal for cards and headers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short")]
        public string? Short { get; set; }

        /// <summary>
        /// Full description of the pricing, perfect for details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full")]
        public string? Full { get; set; }

        /// <summary>
        /// Could be used to generate pricing tables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public object? Table { get; set; }

        /// <summary>
        /// Default Value: input_character_length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_input_chars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerInputChars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputCharacterLength" /> class.
        /// </summary>
        /// <param name="short">
        /// Short description of the pricing, ideal for cards and headers
        /// </param>
        /// <param name="full">
        /// Full description of the pricing, perfect for details
        /// </param>
        /// <param name="table">
        /// Could be used to generate pricing tables
        /// </param>
        /// <param name="type">
        /// Default Value: input_character_length
        /// </param>
        /// <param name="centsPerInputChars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingInputCharacterLength(
            double centsPerInputChars,
            string? @short,
            string? full,
            object? table,
            string? type)
        {
            this.CentsPerInputChars = centsPerInputChars;
            this.Short = @short;
            this.Full = full;
            this.Table = table;
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