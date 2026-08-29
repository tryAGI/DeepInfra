
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RebalanceStatus
    {
        /// <summary>
        /// Id of the rebalance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplaceId { get; set; }

        /// <summary>
        /// Whether this deployment is the source or the target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.RebalanceStatusDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.RebalanceStatusDirection Direction { get; set; }

        /// <summary>
        /// Rebalance status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Target instances delivered so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Placed { get; set; }

        /// <summary>
        /// Target instances requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Deploy Id of the source; empty if not yours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_deploy_id")]
        public string? SourceDeployId { get; set; }

        /// <summary>
        /// Deploy Id of the target; empty if not yours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_deploy_id")]
        public string? TargetDeployId { get; set; }

        /// <summary>
        /// Model name of the source; empty if not yours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_model_name")]
        public string? SourceModelName { get; set; }

        /// <summary>
        /// Model name of the target; empty if not yours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_model_name")]
        public string? TargetModelName { get; set; }

        /// <summary>
        /// Failure reason, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// When the rebalance was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// When the rebalance finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public string? FinishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceStatus" /> class.
        /// </summary>
        /// <param name="replaceId">
        /// Id of the rebalance.
        /// </param>
        /// <param name="direction">
        /// Whether this deployment is the source or the target.
        /// </param>
        /// <param name="status">
        /// Rebalance status.
        /// </param>
        /// <param name="placed">
        /// Target instances delivered so far.
        /// </param>
        /// <param name="count">
        /// Target instances requested.
        /// </param>
        /// <param name="sourceDeployId">
        /// Deploy Id of the source; empty if not yours.
        /// </param>
        /// <param name="targetDeployId">
        /// Deploy Id of the target; empty if not yours.
        /// </param>
        /// <param name="sourceModelName">
        /// Model name of the source; empty if not yours.
        /// </param>
        /// <param name="targetModelName">
        /// Model name of the target; empty if not yours.
        /// </param>
        /// <param name="error">
        /// Failure reason, if any.
        /// </param>
        /// <param name="createdAt">
        /// When the rebalance was requested.
        /// </param>
        /// <param name="finishedAt">
        /// When the rebalance finished.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RebalanceStatus(
            string replaceId,
            global::DeepInfra.RebalanceStatusDirection direction,
            string status,
            int placed,
            int count,
            string? sourceDeployId,
            string? targetDeployId,
            string? sourceModelName,
            string? targetModelName,
            string? error,
            string? createdAt,
            string? finishedAt)
        {
            this.ReplaceId = replaceId ?? throw new global::System.ArgumentNullException(nameof(replaceId));
            this.Direction = direction;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Placed = placed;
            this.Count = count;
            this.SourceDeployId = sourceDeployId;
            this.TargetDeployId = targetDeployId;
            this.SourceModelName = sourceModelName;
            this.TargetModelName = targetModelName;
            this.Error = error;
            this.CreatedAt = createdAt;
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceStatus" /> class.
        /// </summary>
        public RebalanceStatus()
        {
        }

    }
}