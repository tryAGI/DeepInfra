
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployStatusOut
    {
        /// <summary>
        /// Deploy Id<br/>
        /// Example: fkj843kjh8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeployId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}