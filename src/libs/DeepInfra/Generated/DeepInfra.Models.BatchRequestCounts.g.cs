
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchRequestCounts
    {
        /// <summary>
        /// Total number of requests in the batch.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Number of requests that completed successfully.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public int? Completed { get; set; }

        /// <summary>
        /// Number of requests that failed.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public int? Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestCounts" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of requests in the batch.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="completed">
        /// Number of requests that completed successfully.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="failed">
        /// Number of requests that failed.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRequestCounts(
            int? total,
            int? completed,
            int? failed)
        {
            this.Total = total;
            this.Completed = completed;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestCounts" /> class.
        /// </summary>
        public BatchRequestCounts()
        {
        }

    }
}