
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenClawMetadataOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_frameworks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.OpenClawAgentFrameworkOut> AgentFrameworks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.OpenClawPlanOut> Plans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawMetadataOut" /> class.
        /// </summary>
        /// <param name="agentFrameworks"></param>
        /// <param name="plans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenClawMetadataOut(
            global::System.Collections.Generic.IList<global::DeepInfra.OpenClawAgentFrameworkOut> agentFrameworks,
            global::System.Collections.Generic.IList<global::DeepInfra.OpenClawPlanOut> plans)
        {
            this.AgentFrameworks = agentFrameworks ?? throw new global::System.ArgumentNullException(nameof(agentFrameworks));
            this.Plans = plans ?? throw new global::System.ArgumentNullException(nameof(plans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawMetadataOut" /> class.
        /// </summary>
        public OpenClawMetadataOut()
        {
        }

    }
}