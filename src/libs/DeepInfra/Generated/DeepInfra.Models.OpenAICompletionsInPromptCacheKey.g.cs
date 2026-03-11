
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// A key to identify prompt cache for reuse across requests. If provided, the prompt will be cached and can be reused in subsequent requests with the same key.
    /// </summary>
    public sealed partial class OpenAICompletionsInPromptCacheKey
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}