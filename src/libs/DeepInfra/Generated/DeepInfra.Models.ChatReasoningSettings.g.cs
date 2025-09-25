
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatReasoningSettings
    {
        /// <summary>
        /// Constrains effort on reasoning for reasoning models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.ChatReasoningSettingsEffortJsonConverter))]
        public global::DeepInfra.ChatReasoningSettingsEffort? Effort { get; set; }

        /// <summary>
        /// Enable or disable reasoning with default parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatReasoningSettings" /> class.
        /// </summary>
        /// <param name="effort">
        /// Constrains effort on reasoning for reasoning models.
        /// </param>
        /// <param name="enabled">
        /// Enable or disable reasoning with default parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatReasoningSettings(
            global::DeepInfra.ChatReasoningSettingsEffort? effort,
            bool? enabled)
        {
            this.Effort = effort;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatReasoningSettings" /> class.
        /// </summary>
        public ChatReasoningSettings()
        {
        }
    }
}