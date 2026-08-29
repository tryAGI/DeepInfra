
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Per-agent-type catalog: keyed by agent_type_id, each entry carries the<br/>
    /// current version and the plans available for that type.
    /// </summary>
    public sealed partial class AgentCatalogOut
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}