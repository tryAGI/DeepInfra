
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// One preset deploy config for an HF model on specific hardware.
    /// </summary>
    public sealed partial class PresetConfigOut
    {
        /// <summary>
        /// Preset id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Config source.<br/>
        /// Default Value: deepinfra
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Inference engine.<br/>
        /// Default Value: vllm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        public string? Engine { get; set; }

        /// <summary>
        /// Allowed Nx&lt;GPU&gt; configs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_configs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> GpuConfigs { get; set; }

        /// <summary>
        /// Engine tuning knobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standard_args")]
        public global::DeepInfra.PresetConfigOutStandardArgs? StandardArgs { get; set; }

        /// <summary>
        /// Raw engine flags; vLLM recipes only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_args")]
        public global::System.Collections.Generic.IList<string>? ExtraArgs { get; set; }

        /// <summary>
        /// Short display name (e.g. "Throughput-optimized").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetConfigOut" /> class.
        /// </summary>
        /// <param name="id">
        /// Preset id.
        /// </param>
        /// <param name="gpuConfigs">
        /// Allowed Nx&lt;GPU&gt; configs.
        /// </param>
        /// <param name="source">
        /// Config source.<br/>
        /// Default Value: deepinfra
        /// </param>
        /// <param name="engine">
        /// Inference engine.<br/>
        /// Default Value: vllm
        /// </param>
        /// <param name="standardArgs">
        /// Engine tuning knobs.
        /// </param>
        /// <param name="extraArgs">
        /// Raw engine flags; vLLM recipes only.
        /// </param>
        /// <param name="label">
        /// Short display name (e.g. "Throughput-optimized").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresetConfigOut(
            string id,
            global::System.Collections.Generic.IList<string> gpuConfigs,
            string? source,
            string? engine,
            global::DeepInfra.PresetConfigOutStandardArgs? standardArgs,
            global::System.Collections.Generic.IList<string>? extraArgs,
            string? label)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Source = source;
            this.Engine = engine;
            this.GpuConfigs = gpuConfigs ?? throw new global::System.ArgumentNullException(nameof(gpuConfigs));
            this.StandardArgs = standardArgs;
            this.ExtraArgs = extraArgs;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetConfigOut" /> class.
        /// </summary>
        public PresetConfigOut()
        {
        }

    }
}