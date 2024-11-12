
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployInstances
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Running { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployInstances" /> class.
        /// </summary>
        /// <param name="running"></param>
        /// <param name="pending"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeployInstances(
            int running,
            int pending)
        {
            this.Running = running;
            this.Pending = pending;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployInstances" /> class.
        /// </summary>
        public DeployInstances()
        {
        }
    }
}