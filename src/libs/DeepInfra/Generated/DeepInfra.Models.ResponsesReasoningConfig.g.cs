
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesReasoningConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::DeepInfra.ResponsesReasoningConfigEffort? Effort { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_summary")]
        public string? GenerateSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesReasoningConfig" /> class.
        /// </summary>
        /// <param name="effort"></param>
        /// <param name="summary"></param>
        /// <param name="generateSummary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesReasoningConfig(
            global::DeepInfra.ResponsesReasoningConfigEffort? effort,
            string? summary,
            string? generateSummary)
        {
            this.Effort = effort;
            this.Summary = summary;
            this.GenerateSummary = generateSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesReasoningConfig" /> class.
        /// </summary>
        public ResponsesReasoningConfig()
        {
        }

    }
}