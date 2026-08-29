
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Anthropic `thinking` config: {type: enabled|disabled|adaptive, budget_tokens}.<br/>
    /// `enabled` is a legacy pre-spec field this endpoint used to accept; it only<br/>
    /// applies when `type` is absent.
    /// </summary>
    public sealed partial class AnthropicThinkingConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::DeepInfra.AnthropicThinkingConfigType2? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_tokens")]
        public int? BudgetTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkingConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="budgetTokens"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicThinkingConfig(
            global::DeepInfra.AnthropicThinkingConfigType2? type,
            int? budgetTokens,
            bool? enabled)
        {
            this.Type = type;
            this.BudgetTokens = budgetTokens;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicThinkingConfig" /> class.
        /// </summary>
        public AnthropicThinkingConfig()
        {
        }

    }
}