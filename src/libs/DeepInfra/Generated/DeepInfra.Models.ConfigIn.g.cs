
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigIn
    {
        /// <summary>
        /// Set usage limit (in USD). Negative means no limit.null/not-set means don't change it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}