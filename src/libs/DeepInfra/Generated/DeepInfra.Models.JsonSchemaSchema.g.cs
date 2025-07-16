
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// The actual JSON schema definition
    /// </summary>
    public sealed partial class JsonSchemaSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}