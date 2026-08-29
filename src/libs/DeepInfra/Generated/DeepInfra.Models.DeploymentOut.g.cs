
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeploymentOut
    {
        /// <summary>
        /// Default Value: legacy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.DeployTypeJsonConverter))]
        public global::DeepInfra.DeployType? Type { get; set; }

        /// <summary>
        /// Deploy Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeployId { get; set; }

        /// <summary>
        /// Model Id from huggingface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Model version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Task { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Failure reason
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FailReason { get; set; }

        /// <summary>
        /// Created at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Updated at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Details about number of instances running right now
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instances")]
        public global::DeepInfra.DeployInstances? Instances { get; set; }

        /// <summary>
        /// Immutable deploy configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::DeepInfra.DeployLLMConfig? Config { get; set; }

        /// <summary>
        /// Scale Settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::DeepInfra.ScaleSettings? Settings { get; set; }

        /// <summary>
        /// Current engine tuning knobs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standard_args")]
        public global::DeepInfra.DeploymentOutStandardArgs? StandardArgs { get; set; }

        /// <summary>
        /// Current extra engine-specific command-line args (custom-weight deploys only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_args")]
        public global::System.Collections.Generic.IList<string>? ExtraArgs { get; set; }

        /// <summary>
        /// If the last config update was auto-reverted after an engine crash-loop, the error that caused it (status stays 'running')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_error")]
        public string? UpdateError { get; set; }

        /// <summary>
        /// Per-instance rollout progress of the current config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollout")]
        public global::DeepInfra.DeployRollout? Rollout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentOut" /> class.
        /// </summary>
        /// <param name="deployId">
        /// Deploy Id
        /// </param>
        /// <param name="modelName">
        /// Model Id from huggingface
        /// </param>
        /// <param name="version">
        /// Model version
        /// </param>
        /// <param name="task">
        /// Task
        /// </param>
        /// <param name="status">
        /// Status
        /// </param>
        /// <param name="failReason">
        /// Failure reason
        /// </param>
        /// <param name="createdAt">
        /// Created at
        /// </param>
        /// <param name="updatedAt">
        /// Updated at
        /// </param>
        /// <param name="type">
        /// Default Value: legacy
        /// </param>
        /// <param name="instances">
        /// Details about number of instances running right now
        /// </param>
        /// <param name="config">
        /// Immutable deploy configuration
        /// </param>
        /// <param name="settings">
        /// Scale Settings
        /// </param>
        /// <param name="standardArgs">
        /// Current engine tuning knobs
        /// </param>
        /// <param name="extraArgs">
        /// Current extra engine-specific command-line args (custom-weight deploys only)
        /// </param>
        /// <param name="updateError">
        /// If the last config update was auto-reverted after an engine crash-loop, the error that caused it (status stays 'running')
        /// </param>
        /// <param name="rollout">
        /// Per-instance rollout progress of the current config
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentOut(
            string deployId,
            string modelName,
            string version,
            string task,
            string status,
            string failReason,
            string createdAt,
            string updatedAt,
            global::DeepInfra.DeployType? type,
            global::DeepInfra.DeployInstances? instances,
            global::DeepInfra.DeployLLMConfig? config,
            global::DeepInfra.ScaleSettings? settings,
            global::DeepInfra.DeploymentOutStandardArgs? standardArgs,
            global::System.Collections.Generic.IList<string>? extraArgs,
            string? updateError,
            global::DeepInfra.DeployRollout? rollout)
        {
            this.Type = type;
            this.DeployId = deployId ?? throw new global::System.ArgumentNullException(nameof(deployId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.FailReason = failReason ?? throw new global::System.ArgumentNullException(nameof(failReason));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Instances = instances;
            this.Config = config;
            this.Settings = settings;
            this.StandardArgs = standardArgs;
            this.ExtraArgs = extraArgs;
            this.UpdateError = updateError;
            this.Rollout = rollout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentOut" /> class.
        /// </summary>
        public DeploymentOut()
        {
        }

    }
}