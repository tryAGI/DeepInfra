
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.ScaleSettings Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMUpdateIn" /> class.
        /// </summary>
        /// <param name="settings"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeployLLMUpdateIn(
            global::DeepInfra.ScaleSettings settings)
        {
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployLLMUpdateIn" /> class.
        /// </summary>
        public DeployLLMUpdateIn()
        {
        }
    }
}