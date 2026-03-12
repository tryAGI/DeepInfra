
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HardwarePricingDedicated
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerMinute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwarePricingDedicated" /> class.
        /// </summary>
        /// <param name="centsPerMinute"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HardwarePricingDedicated(
            double centsPerMinute)
        {
            this.CentsPerMinute = centsPerMinute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwarePricingDedicated" /> class.
        /// </summary>
        public HardwarePricingDedicated()
        {
        }
    }
}