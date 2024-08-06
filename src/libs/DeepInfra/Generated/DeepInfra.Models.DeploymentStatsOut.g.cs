
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentStatsOut
    {
        /// <summary>
        /// number of inference requests in the provided interval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// total number of seconds spend in inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTime { get; set; }

        /// <summary>
        /// total number of tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// number of input tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// number of output tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// total number of cents spent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAmount { get; set; }

        /// <summary>
        /// average millisecond inference time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgTime { get; set; }

        /// <summary>
        /// 95th percentile inference time (estimated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg95_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Avg95Time { get; set; }

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