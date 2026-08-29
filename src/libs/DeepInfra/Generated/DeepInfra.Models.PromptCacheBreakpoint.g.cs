
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptCacheBreakpoint
    {
        /// <summary>
        /// Breakpoint mode; 'explicit' bounds cache retention to the prompt prefix ending at this content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheBreakpoint" /> class.
        /// </summary>
        /// <param name="mode">
        /// Breakpoint mode; 'explicit' bounds cache retention to the prompt prefix ending at this content part.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCacheBreakpoint(
            string? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheBreakpoint" /> class.
        /// </summary>
        public PromptCacheBreakpoint()
        {
        }

    }
}