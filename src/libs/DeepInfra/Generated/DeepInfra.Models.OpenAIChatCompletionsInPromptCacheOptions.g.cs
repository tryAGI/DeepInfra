
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Prompt cache options for this request's prefix, e.g. {"ttl": "1h"}.
    /// </summary>
    public sealed partial class OpenAIChatCompletionsInPromptCacheOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}