
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentCreateIn
    {
        /// <summary>
        /// Instance name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Agent type identifier<br/>
        /// Default Value: openclaw
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type_id")]
        public string? AgentTypeId { get; set; }

        /// <summary>
        /// Plan identifier<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public string? PlanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateIn" /> class.
        /// </summary>
        /// <param name="name">
        /// Instance name
        /// </param>
        /// <param name="agentTypeId">
        /// Agent type identifier<br/>
        /// Default Value: openclaw
        /// </param>
        /// <param name="planId">
        /// Plan identifier<br/>
        /// Default Value: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCreateIn(
            string name,
            string? agentTypeId,
            string? planId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentTypeId = agentTypeId;
            this.PlanId = planId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateIn" /> class.
        /// </summary>
        public AgentCreateIn()
        {
        }

    }
}