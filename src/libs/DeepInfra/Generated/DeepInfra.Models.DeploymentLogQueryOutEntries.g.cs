
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// mapping of pod names to log lines ordered by increasing timestamp
    /// </summary>
    public sealed partial class DeploymentLogQueryOutEntries
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentLogQueryOutEntries" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeploymentLogQueryOutEntries(
 )
        {
        }
    }
}