
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Optional multi-modal data to pass alongside the prompt. Only supported for a small number of non-chat-native vision models. Images must be base64 data URIs (e.g. 'data:image/png;base64,...').
    /// </summary>
    public sealed partial class OpenAICompletionsInData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}