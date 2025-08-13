
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingOutputLength
    {
        /// <summary>
        /// Default Value: output_length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_output_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerOutputSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingOutputLength" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: output_length
        /// </param>
        /// <param name="centsPerOutputSec"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingOutputLength(
            double centsPerOutputSec,
            string? type)
        {
            this.CentsPerOutputSec = centsPerOutputSec;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingOutputLength" /> class.
        /// </summary>
        public ModelPricingOutputLength()
        {
        }
    }
}