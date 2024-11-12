
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingTime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerSec { get; set; }

        /// <summary>
        /// Default Value: time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTime" /> class.
        /// </summary>
        /// <param name="centsPerSec"></param>
        /// <param name="type">
        /// Default Value: time
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelPricingTime(
            double centsPerSec,
            string? type)
        {
            this.CentsPerSec = centsPerSec;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTime" /> class.
        /// </summary>
        public ModelPricingTime()
        {
        }
    }
}