
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// The format in which the generated images are returned. Currently only b64_json is supported.<br/>
    /// Default Value: b64_json
    /// </summary>
    public sealed partial class OpenAIImagesEditsInResponseFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}