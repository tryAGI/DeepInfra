
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    public enum BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        VerboseJson,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat value)
        {
            return value switch
            {
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.Json => "json",
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.VerboseJson => "verbose_json",
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.Text => "text",
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.Srt => "srt",
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.Json,
                "verbose_json" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.VerboseJson,
                "text" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.Text,
                "srt" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.Srt,
                "vtt" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}