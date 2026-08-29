
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RebalanceOut
    {
        /// <summary>
        /// Id of the started rebalance; empty on a dry run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_id")]
        public string? ReplaceId { get; set; }

        /// <summary>
        /// GPU type being rebalanced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gpu { get; set; }

        /// <summary>
        /// Source instances now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_instances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SourceInstances { get; set; }

        /// <summary>
        /// Source instances once the rebalance completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_instances_after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SourceInstancesAfter { get; set; }

        /// <summary>
        /// Target instances now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_instances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetInstances { get; set; }

        /// <summary>
        /// Target instances once the rebalance completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_instances_after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetInstancesAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceOut" /> class.
        /// </summary>
        /// <param name="gpu">
        /// GPU type being rebalanced.
        /// </param>
        /// <param name="sourceInstances">
        /// Source instances now.
        /// </param>
        /// <param name="sourceInstancesAfter">
        /// Source instances once the rebalance completes.
        /// </param>
        /// <param name="targetInstances">
        /// Target instances now.
        /// </param>
        /// <param name="targetInstancesAfter">
        /// Target instances once the rebalance completes.
        /// </param>
        /// <param name="replaceId">
        /// Id of the started rebalance; empty on a dry run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RebalanceOut(
            string gpu,
            int sourceInstances,
            int sourceInstancesAfter,
            int targetInstances,
            int targetInstancesAfter,
            string? replaceId)
        {
            this.ReplaceId = replaceId;
            this.Gpu = gpu ?? throw new global::System.ArgumentNullException(nameof(gpu));
            this.SourceInstances = sourceInstances;
            this.SourceInstancesAfter = sourceInstancesAfter;
            this.TargetInstances = targetInstances;
            this.TargetInstancesAfter = targetInstancesAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceOut" /> class.
        /// </summary>
        public RebalanceOut()
        {
        }

    }
}