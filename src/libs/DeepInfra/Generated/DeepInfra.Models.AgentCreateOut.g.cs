
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentCreateOut
    {
        /// <summary>
        /// Instance ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateOut" /> class.
        /// </summary>
        /// <param name="instanceId">
        /// Instance ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCreateOut(
            string instanceId)
        {
            this.InstanceId = instanceId ?? throw new global::System.ArgumentNullException(nameof(instanceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateOut" /> class.
        /// </summary>
        public AgentCreateOut()
        {
        }

    }
}