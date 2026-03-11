
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// A list of statuses that should be returned, separated by comma. Allowed values in the list are: initializing,downloading,deploying,running,stopped,failed,deleted
    /// </summary>
    public sealed partial class DeployListDeployListGetStatus
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}