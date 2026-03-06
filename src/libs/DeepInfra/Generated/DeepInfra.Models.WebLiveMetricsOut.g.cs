
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebLiveMetricsOut
    {
        /// <summary>
        /// Tokens per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_per_second")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? TokensPerSecond { get; set; }

        /// <summary>
        /// Time to first token in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_to_first_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? TimeToFirstToken { get; set; }

        /// <summary>
        /// Requests per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_second")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? RequestsPerSecond { get; set; }

        /// <summary>
        /// Total TFLOPS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tflops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? TotalTflops { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebLiveMetricsOut" /> class.
        /// </summary>
        /// <param name="tokensPerSecond">
        /// Tokens per second
        /// </param>
        /// <param name="timeToFirstToken">
        /// Time to first token in seconds
        /// </param>
        /// <param name="requestsPerSecond">
        /// Requests per second
        /// </param>
        /// <param name="totalTflops">
        /// Total TFLOPS
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebLiveMetricsOut(
            double? tokensPerSecond,
            double? timeToFirstToken,
            double? requestsPerSecond,
            double? totalTflops)
        {
            this.TokensPerSecond = tokensPerSecond;
            this.TimeToFirstToken = timeToFirstToken;
            this.RequestsPerSecond = requestsPerSecond;
            this.TotalTflops = totalTflops;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebLiveMetricsOut" /> class.
        /// </summary>
        public WebLiveMetricsOut()
        {
        }
    }
}