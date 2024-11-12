
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMDeploymentStatsOut
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
        /// number of output tokens generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// average millisecond time to first token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_ttft_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgTtftMs { get; set; }

        /// <summary>
        /// 95th percentile time to first token (estimated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg95_ttft_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Avg95TtftMs { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMDeploymentStatsOut" /> class.
        /// </summary>
        /// <param name="requests">
        /// number of inference requests in the provided interval
        /// </param>
        /// <param name="inputTokens">
        /// number of input tokens generated
        /// </param>
        /// <param name="outputTokens">
        /// number of output tokens generated
        /// </param>
        /// <param name="avgTtftMs">
        /// average millisecond time to first token
        /// </param>
        /// <param name="avg95TtftMs">
        /// 95th percentile time to first token (estimated)
        /// </param>
        /// <param name="avgTptMs">
        /// average millisecond time per token
        /// </param>
        /// <param name="avg95TptMs">
        /// 95th percentile time per token (estimated)
        /// </param>
        /// <param name="totalAmountCents">
        /// total number of cents spent
        /// </param>
        /// <param name="errors">
        /// number of errors
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LLMDeploymentStatsOut(
            int requests,
            int inputTokens,
            int outputTokens,
            double avgTtftMs,
            double avg95TtftMs,
            double avgTptMs,
            double avg95TptMs,
            int totalAmountCents,
            int errors)
        {
            this.Requests = requests;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.AvgTtftMs = avgTtftMs;
            this.Avg95TtftMs = avg95TtftMs;
            this.AvgTptMs = avgTptMs;
            this.Avg95TptMs = avg95TptMs;
            this.TotalAmountCents = totalAmountCents;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMDeploymentStatsOut" /> class.
        /// </summary>
        public LLMDeploymentStatsOut()
        {
        }
    }
}