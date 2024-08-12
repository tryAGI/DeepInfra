
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployLLMConfig
    {
        /// <summary>
        /// The type of GPU the deployment is running on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.AllOf<global::DeepInfra.DeployGPUs?> Gpu { get; set; }

        /// <summary>
        /// Number of GPUs used by one instance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumGpus { get; set; }

        /// <summary>
        /// Maximum number of concurrent requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBatchSize { get; set; }

        /// <summary>
        /// Model weights information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.AllOf<global::DeepInfra.HFWeights> Weights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}