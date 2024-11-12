
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingInputLength
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_input_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerInputSec { get; set; }

        /// <summary>
        /// Default Value: input_length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputLength" /> class.
        /// </summary>
        /// <param name="centsPerInputSec"></param>
        /// <param name="type">
        /// Default Value: input_length
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelPricingInputLength(
            double centsPerInputSec,
            string? type)
        {
            this.CentsPerInputSec = centsPerInputSec;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingInputLength" /> class.
        /// </summary>
        public ModelPricingInputLength()
        {
        }
    }
}