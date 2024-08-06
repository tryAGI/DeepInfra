
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelVersionOut
    {
        /// <summary>
        /// Model Name<br/>
        /// Example: microsoft/resnet-50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Version identifier<br/>
        /// Example: 06dbf5f73be4b5eca79e137e00c4825f467cd5b172c64b6c9255dc4b5a25a03a
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Upload time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UploadedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}