
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptCacheOptions
    {
        /// <summary>
        /// Prompt caching mode; 'explicit' requests explicit caching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public global::DeepInfra.PromptCacheOptionsMode2? Mode { get; set; }

        /// <summary>
        /// Requested cache retention for this request's prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public global::DeepInfra.PromptCacheOptionsTtl2? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheOptions" /> class.
        /// </summary>
        /// <param name="mode">
        /// Prompt caching mode; 'explicit' requests explicit caching.
        /// </param>
        /// <param name="ttl">
        /// Requested cache retention for this request's prefix.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCacheOptions(
            global::DeepInfra.PromptCacheOptionsMode2? mode,
            global::DeepInfra.PromptCacheOptionsTtl2? ttl)
        {
            this.Mode = mode;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheOptions" /> class.
        /// </summary>
        public PromptCacheOptions()
        {
        }

    }
}