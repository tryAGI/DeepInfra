
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RebalanceIn
    {
        /// <summary>
        /// Deployment to grow using GPUs freed from this one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_deploy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetDeployId { get; set; }

        /// <summary>
        /// Number of target instances to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Validate and preview without moving anything.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceIn" /> class.
        /// </summary>
        /// <param name="targetDeployId">
        /// Deployment to grow using GPUs freed from this one.
        /// </param>
        /// <param name="count">
        /// Number of target instances to create.
        /// </param>
        /// <param name="dryRun">
        /// Validate and preview without moving anything.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RebalanceIn(
            string targetDeployId,
            int count,
            bool? dryRun)
        {
            this.TargetDeployId = targetDeployId ?? throw new global::System.ArgumentNullException(nameof(targetDeployId));
            this.Count = count;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceIn" /> class.
        /// </summary>
        public RebalanceIn()
        {
        }

    }
}