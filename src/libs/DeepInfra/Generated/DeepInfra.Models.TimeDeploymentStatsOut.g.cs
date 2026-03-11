
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeDeploymentStatsOut
    {
        /// <summary>
        /// number of inference requests in the provided interval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Requests { get; set; } = default!;

        /// <summary>
        /// total number of seconds spend in inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_time_s")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalTimeS { get; set; } = default!;

        /// <summary>
        /// total number of cents spent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_amount_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalAmountCents { get; set; } = default!;

        /// <summary>
        /// average millisecond inference time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double AvgTimeMs { get; set; } = default!;

        /// <summary>
        /// 95th percentile inference time (estimated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg95_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double Avg95TimeMs { get; set; } = default!;

        /// <summary>
        /// number of errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Errors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeDeploymentStatsOut" /> class.
        /// </summary>
        /// <param name="requests">
        /// number of inference requests in the provided interval
        /// </param>
        /// <param name="totalTimeS">
        /// total number of seconds spend in inference
        /// </param>
        /// <param name="totalAmountCents">
        /// total number of cents spent
        /// </param>
        /// <param name="avgTimeMs">
        /// average millisecond inference time
        /// </param>
        /// <param name="avg95TimeMs">
        /// 95th percentile inference time (estimated)
        /// </param>
        /// <param name="errors">
        /// number of errors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeDeploymentStatsOut(
            int requests,
            int totalTimeS,
            int totalAmountCents,
            double avgTimeMs,
            double avg95TimeMs,
            int errors)
        {
            this.Requests = requests;
            this.TotalTimeS = totalTimeS;
            this.TotalAmountCents = totalAmountCents;
            this.AvgTimeMs = avgTimeMs;
            this.Avg95TimeMs = avg95TimeMs;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeDeploymentStatsOut" /> class.
        /// </summary>
        public TimeDeploymentStatsOut()
        {
        }
    }
}