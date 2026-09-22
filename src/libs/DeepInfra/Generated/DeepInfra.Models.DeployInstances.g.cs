
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// A deployment's capacity: running + pending + warming.
    /// </summary>
    public sealed partial class DeployInstances
    {
        /// <summary>
        /// Instances serving at full capacity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Running { get; set; }

        /// <summary>
        /// Instances still starting up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pending { get; set; }

        /// <summary>
        /// Instances that are up but still warming up, so they take a reduced share of the traffic.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warming")]
        public int? Warming { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployInstances" /> class.
        /// </summary>
        /// <param name="running">
        /// Instances serving at full capacity.
        /// </param>
        /// <param name="pending">
        /// Instances still starting up.
        /// </param>
        /// <param name="warming">
        /// Instances that are up but still warming up, so they take a reduced share of the traffic.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeployInstances(
            int running,
            int pending,
            int? warming)
        {
            this.Running = running;
            this.Pending = pending;
            this.Warming = warming;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployInstances" /> class.
        /// </summary>
        public DeployInstances()
        {
        }

    }
}