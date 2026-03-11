
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// The service tier used for processing the request. When set to 'priority', the request will be processed with higher priority (only applies to models that support it).
    /// </summary>
    public sealed partial class OpenAITextToSpeechInServiceTier
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}