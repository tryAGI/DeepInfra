
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeployLLMUpdateIn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::DeepInfra.ScaleSettings? Settings { get; set; }

        /// <summary>
        /// Engine tuning knobs. Replaces the whole set; omitted knobs are cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standard_args")]
        public global::DeepInfra.StandardArgs? StandardArgs { get; set; }

        /// <summary>
        /// Extra engine-specific command-line args (custom-weight deploys only). Replaces the whole list; omitted args are cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_args")]
        public global::System.Collections.Generic.IList<string>? ExtraArgs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMUpdateIn" /> class.
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="standardArgs">
        /// Engine tuning knobs. Replaces the whole set; omitted knobs are cleared.
        /// </param>
        /// <param name="extraArgs">
        /// Extra engine-specific command-line args (custom-weight deploys only). Replaces the whole list; omitted args are cleared.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeployLLMUpdateIn(
            global::DeepInfra.ScaleSettings? settings,
            global::DeepInfra.StandardArgs? standardArgs,
            global::System.Collections.Generic.IList<string>? extraArgs)
        {
            this.Settings = settings;
            this.StandardArgs = standardArgs;
            this.ExtraArgs = extraArgs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMUpdateIn" /> class.
        /// </summary>
        public DeployLLMUpdateIn()
        {
        }

    }
}