
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogQueryOut
    {
        /// <summary>
        /// list of log lines ordered by increasing timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::DeepInfra.LogQueryOutEntrieItem>>? Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}