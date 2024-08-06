
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentOut
    {
        /// <summary>
        /// Default Value: legacy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        public global::System.AllOf<global::DeepInfra.DeployType?>? Type { get; set; } = DeployType.Legacy;

        /// <summary>
        /// Deploy Id<br/>
        /// Example: fkj843kjh8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeployId { get; set; }

        /// <summary>
        /// Model Id from huggingface<br/>
        /// Example: google/vit-base-patch16-224
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Model version<br/>
        /// Example: d8b79b422843bd59d628bf25b01aded94a9ec1a9b917e69fe460df9ff39ec42b
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Task<br/>
        /// Example: image-classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Task { get; set; }

        /// <summary>
        /// Status<br/>
        /// Example: deployed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Failure reason<br/>
        /// Example: Initialization failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FailReason { get; set; }

        /// <summary>
        /// Created at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updated at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Details about number of instances running right now
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instances")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        public global::System.AllOf<global::DeepInfra.DeployInstances?>? Instances { get; set; }

        /// <summary>
        /// Immutable deploy configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        public global::System.AllOf<global::DeepInfra.DeployLLMConfig?>? Config { get; set; }

        /// <summary>
        /// Scale Settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        public global::System.AllOf<global::DeepInfra.ScaleSettings?>? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}