
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployLLMConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.DeployGPUsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.DeployGPUs Gpu { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        public global::DeepInfra.HFWeights? Weights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMConfig" /> class.
        /// </summary>
        /// <param name="gpu"></param>
        /// <param name="numGpus">
        /// Number of GPUs used by one instance
        /// </param>
        /// <param name="maxBatchSize">
        /// Maximum number of concurrent requests
        /// </param>
        /// <param name="weights"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeployLLMConfig(
            global::DeepInfra.DeployGPUs gpu,
            int numGpus,
            int maxBatchSize,
            global::DeepInfra.HFWeights? weights)
        {
            this.Gpu = gpu;
            this.NumGpus = numGpus;
            this.MaxBatchSize = maxBatchSize;
            this.Weights = weights;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMConfig" /> class.
        /// </summary>
        public DeployLLMConfig()
        {
        }
    }
}