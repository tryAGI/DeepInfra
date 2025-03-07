
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.ChatCompletionContentPartAudioTypeJsonConverter))]
        public global::DeepInfra.ChatCompletionContentPartAudioType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.InputAudio InputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartAudio" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="inputAudio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartAudio(
            global::DeepInfra.InputAudio inputAudio,
            global::DeepInfra.ChatCompletionContentPartAudioType type)
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartAudio" /> class.
        /// </summary>
        public ChatCompletionContentPartAudio()
        {
        }
    }
}