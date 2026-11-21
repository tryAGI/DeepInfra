
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeployLLMIn
    {
        /// <summary>
        /// model name for deepinfra (username/mode-name format)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// The type of GPU the deployment is running on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.DeployGPUsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.DeployGPUs Gpu { get; set; }

        /// <summary>
        /// Number of GPUs used by one instance<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_gpus")]
        public int? NumGpus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf")]
        public global::DeepInfra.HFWeights? Hf { get; set; }

        /// <summary>
        /// Base public model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Docker image for the deployment: vllm/vllm-openai:latest or an x86 release tag (e.g. vllm/vllm-openai:v0.34.0). nightly is not accepted. The tag is resolved to its digest once, when the deployment is created, and the deployment keeps running that image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_image")]
        public string? ContainerImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::DeepInfra.ScaleSettings? Settings { get; set; }

        /// <summary>
        /// No longer accepted: a non-empty value is rejected. Use standard_args or preset_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_args")]
        public global::System.Collections.Generic.IList<string>? ExtraArgs { get; set; }

        /// <summary>
        /// Engine tuning knobs. Values are validated on submission; unsupported or out-of-range values are rejected. Unset knobs use the model/engine defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standard_args")]
        public global::DeepInfra.StandardArgs? StandardArgs { get; set; }

        /// <summary>
        /// Apply a stored preset or vLLM recipe by id. A non-empty standard_args in this request replaces the preset's whole standard_args.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_id")]
        public string? PresetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMIn" /> class.
        /// </summary>
        /// <param name="modelName">
        /// model name for deepinfra (username/mode-name format)
        /// </param>
        /// <param name="gpu">
        /// The type of GPU the deployment is running on.
        /// </param>
        /// <param name="numGpus">
        /// Number of GPUs used by one instance<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="hf"></param>
        /// <param name="baseModel">
        /// Base public model
        /// </param>
        /// <param name="containerImage">
        /// Docker image for the deployment: vllm/vllm-openai:latest or an x86 release tag (e.g. vllm/vllm-openai:v0.34.0). nightly is not accepted. The tag is resolved to its digest once, when the deployment is created, and the deployment keeps running that image.
        /// </param>
        /// <param name="settings"></param>
        /// <param name="extraArgs">
        /// No longer accepted: a non-empty value is rejected. Use standard_args or preset_id.
        /// </param>
        /// <param name="standardArgs">
        /// Engine tuning knobs. Values are validated on submission; unsupported or out-of-range values are rejected. Unset knobs use the model/engine defaults.
        /// </param>
        /// <param name="presetId">
        /// Apply a stored preset or vLLM recipe by id. A non-empty standard_args in this request replaces the preset's whole standard_args.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeployLLMIn(
            string modelName,
            global::DeepInfra.DeployGPUs gpu,
            int? numGpus,
            global::DeepInfra.HFWeights? hf,
            string? baseModel,
            string? containerImage,
            global::DeepInfra.ScaleSettings? settings,
            global::System.Collections.Generic.IList<string>? extraArgs,
            global::DeepInfra.StandardArgs? standardArgs,
            string? presetId)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Gpu = gpu;
            this.NumGpus = numGpus;
            this.Hf = hf;
            this.BaseModel = baseModel;
            this.ContainerImage = containerImage;
            this.Settings = settings;
            this.ExtraArgs = extraArgs;
            this.StandardArgs = standardArgs;
            this.PresetId = presetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMIn" /> class.
        /// </summary>
        public DeployLLMIn()
        {
        }

    }
}