
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
        /// How many target instances may start at once (default 1). Higher finishes sooner at a deeper dip in source capacity; clamped to count. How many source instances that takes down depends on their relative size: one target instance the size of 4 source instances stops 4 of them at once, while a source instance that yields 4 target instances is always drained in one go, starting all 4.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public int? Concurrency { get; set; }

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
        /// <param name="concurrency">
        /// How many target instances may start at once (default 1). Higher finishes sooner at a deeper dip in source capacity; clamped to count. How many source instances that takes down depends on their relative size: one target instance the size of 4 source instances stops 4 of them at once, while a source instance that yields 4 target instances is always drained in one go, starting all 4.<br/>
        /// Default Value: 1
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
            int? concurrency,
            bool? dryRun)
        {
            this.TargetDeployId = targetDeployId ?? throw new global::System.ArgumentNullException(nameof(targetDeployId));
            this.Count = count;
            this.Concurrency = concurrency;
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