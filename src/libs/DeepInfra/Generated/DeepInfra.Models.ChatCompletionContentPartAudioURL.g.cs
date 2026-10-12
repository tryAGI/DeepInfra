
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionContentPartAudioURL
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"audio_url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "audio_url";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AudioURL AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartAudioURL" /> class.
        /// </summary>
        /// <param name="audioUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionContentPartAudioURL(
            global::DeepInfra.AudioURL audioUrl,
            string type = "audio_url")
        {
            this.Type = type;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartAudioURL" /> class.
        /// </summary>
        public ChatCompletionContentPartAudioURL()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionContentPartAudioURL"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionContentPartAudioURL FromAudioUrl(global::DeepInfra.AudioURL audioUrl)
        {
            return new ChatCompletionContentPartAudioURL
            {
                AudioUrl = audioUrl,
            };
        }

    }
}