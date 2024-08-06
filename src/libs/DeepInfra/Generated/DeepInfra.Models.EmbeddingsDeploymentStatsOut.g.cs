
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsDeploymentStatsOut
    {
        /// <summary>
        /// number of inference requests in the provided interval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// number of input tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// average millisecond time per token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_tpt_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgTptMs { get; set; }

        /// <summary>
        /// 95th percentile time per token (estimated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg95_tpt_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Avg95TptMs { get; set; }

        /// <summary>
        /// total number of cents spent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_amount_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAmountCents { get; set; }

        /// <summary>
        /// number of errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}