
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// If set, the final assistant message is used as a prefix for the model to continue generating from, rather than starting a new turn. Only applicable when the last message in the conversation is an assistant message.
    /// </summary>
    public sealed partial class OpenAIChatCompletionsInContinueFinalMessage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}