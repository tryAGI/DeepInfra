
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAITextToSpeechIn
    {
        /// <summary>
        /// The service tier used for processing the request. 'priority' processes the request with higher priority (premium rate); 'flex' processes it at lower priority for a discount, served only when spare capacity exists and may be retried/timed out under load. Both apply only to models that support the respective tier. For compatibility, 'auto' is treated as 'priority' and 'standard_only' as 'default'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::DeepInfra.ServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// If true, the request is rejected immediately with HTTP 429 when the model has no spare capacity, instead of waiting in the queue. Opt-in; the default (false) keeps standard queueing behavior.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_fast")]
        public bool? FailFast { get; set; }

        /// <summary>
        /// model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Text to convert to speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Preset voices to use for the speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// response format for the speech<br/>
        /// Default Value: wav
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.TtsResponseFormatJsonConverter))]
        public global::DeepInfra.TtsResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// speed of the speech<br/>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Extra body parameters for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_body")]
        public object? ExtraBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAITextToSpeechIn" /> class.
        /// </summary>
        /// <param name="model">
        /// model name
        /// </param>
        /// <param name="input">
        /// Text to convert to speech
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used for processing the request. 'priority' processes the request with higher priority (premium rate); 'flex' processes it at lower priority for a discount, served only when spare capacity exists and may be retried/timed out under load. Both apply only to models that support the respective tier. For compatibility, 'auto' is treated as 'priority' and 'standard_only' as 'default'.
        /// </param>
        /// <param name="failFast">
        /// If true, the request is rejected immediately with HTTP 429 when the model has no spare capacity, instead of waiting in the queue. Opt-in; the default (false) keeps standard queueing behavior.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="voice">
        /// Preset voices to use for the speech.
        /// </param>
        /// <param name="responseFormat">
        /// response format for the speech<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="speed">
        /// speed of the speech<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="extraBody">
        /// Extra body parameters for the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAITextToSpeechIn(
            string model,
            string input,
            global::DeepInfra.ServiceTier? serviceTier,
            bool? failFast,
            string? voice,
            global::DeepInfra.TtsResponseFormat? responseFormat,
            double? speed,
            object? extraBody)
        {
            this.ServiceTier = serviceTier;
            this.FailFast = failFast;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Voice = voice;
            this.ResponseFormat = responseFormat;
            this.Speed = speed;
            this.ExtraBody = extraBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAITextToSpeechIn" /> class.
        /// </summary>
        public OpenAITextToSpeechIn()
        {
        }

    }
}