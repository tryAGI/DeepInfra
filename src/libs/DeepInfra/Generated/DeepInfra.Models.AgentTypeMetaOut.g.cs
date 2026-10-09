
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTypeMetaOut
    {
        /// <summary>
        /// Human-readable display name for the framework
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pretty_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrettyName { get; set; }

        /// <summary>
        /// Agent framework version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Whether instances of this framework expose a dashboard via the nginx proxy. False -&gt; SSH-only; the UI should hide the dashboard launch affordance and surface the SSH connection string instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_dashboard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasDashboard { get; set; }

        /// <summary>
        /// Non-empty when instances of this framework update themselves: the command the customer runs over SSH. POST /{id}/update refuses such instances, so the UI should show this command instead of the in-place Update action and skip the catalog-version comparison (the instance's version pin does not move after a self-service update).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_service_update_command")]
        public string? SelfServiceUpdateCommand { get; set; }

        /// <summary>
        /// Plans available for this agent type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.AgentPlanOut> Plans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTypeMetaOut" /> class.
        /// </summary>
        /// <param name="prettyName">
        /// Human-readable display name for the framework
        /// </param>
        /// <param name="version">
        /// Agent framework version
        /// </param>
        /// <param name="hasDashboard">
        /// Whether instances of this framework expose a dashboard via the nginx proxy. False -&gt; SSH-only; the UI should hide the dashboard launch affordance and surface the SSH connection string instead.
        /// </param>
        /// <param name="plans">
        /// Plans available for this agent type
        /// </param>
        /// <param name="selfServiceUpdateCommand">
        /// Non-empty when instances of this framework update themselves: the command the customer runs over SSH. POST /{id}/update refuses such instances, so the UI should show this command instead of the in-place Update action and skip the catalog-version comparison (the instance's version pin does not move after a self-service update).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTypeMetaOut(
            string prettyName,
            string version,
            bool hasDashboard,
            global::System.Collections.Generic.IList<global::DeepInfra.AgentPlanOut> plans,
            string? selfServiceUpdateCommand)
        {
            this.PrettyName = prettyName ?? throw new global::System.ArgumentNullException(nameof(prettyName));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.HasDashboard = hasDashboard;
            this.SelfServiceUpdateCommand = selfServiceUpdateCommand;
            this.Plans = plans ?? throw new global::System.ArgumentNullException(nameof(plans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTypeMetaOut" /> class.
        /// </summary>
        public AgentTypeMetaOut()
        {
        }

    }
}