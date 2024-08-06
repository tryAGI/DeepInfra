
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.ModelMeta Model { get; set; }

        /// <summary>
        /// billed seconds or tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Units { get; set; }

        /// <summary>
        /// rate in cents/sec or cents per token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// model cost in cents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Cost { get; set; }

        /// <summary>
        /// pricing type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PricingType { get; set; }

        /// <summary>
        /// time interval with this particular pricing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.AllOf<global::DeepInfra.TimeInterval?> Interval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}