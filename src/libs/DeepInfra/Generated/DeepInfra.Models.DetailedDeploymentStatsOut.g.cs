
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedDeploymentStatsOut
    {
        /// <summary>
        /// LLM Deployment Stats
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::DeepInfra.LLMDeploymentStatsOut? Llm { get; set; }

        /// <summary>
        /// Embeddings Deployment Stats
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::DeepInfra.EmbeddingsDeploymentStatsOut? Embeddings { get; set; }

        /// <summary>
        /// Time based Deployment Stats
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public global::DeepInfra.TimeDeploymentStatsOut? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}