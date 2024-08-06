
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAITextToSpeechIn
    {
        /// <summary>
        /// The webhook to call when inference is done, by default you will get the output in the response of your inference request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// model name<br/>
        /// Example: deepinfra/tts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// text to convert to speech<br/>
        /// Example: Hello, how are you?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Preset voices to use for the speech.<br/>
        /// Default Value: luna
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        public global::System.AllOf<global::DeepInfra.TtsVoice?>? Voice { get; set; } = "luna";

        /// <summary>
        /// response format for the speech<br/>
        /// Default Value: wav
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1))]
        public global::System.AllOf<global::DeepInfra.TtsResponseFormat?>? ResponseFormat { get; set; } = "wav";

        /// <summary>
        /// speed of the speech<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double Speed { get; set; } = 1;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}