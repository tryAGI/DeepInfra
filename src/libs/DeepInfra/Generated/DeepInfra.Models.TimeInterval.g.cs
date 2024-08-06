
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Inclusive, in ms
    /// </summary>
    public sealed partial class TimeInterval
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fr")]
        public int Fr { get; set; } = 0;

        /// <summary>
        /// Default Value: 4000000000000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public long To { get; set; } = 4000000000000;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}