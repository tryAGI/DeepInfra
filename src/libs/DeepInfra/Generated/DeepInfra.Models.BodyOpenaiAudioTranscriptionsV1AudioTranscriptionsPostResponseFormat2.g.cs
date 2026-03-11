
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2
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
    public static class BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2 value)
        {
            return value switch
            {
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.Json => "json",
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.VerboseJson => "verbose_json",
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.Text => "text",
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.Srt => "srt",
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.Json,
                "verbose_json" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.VerboseJson,
                "text" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.Text,
                "srt" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.Srt,
                "vtt" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2.Vtt,
                _ => null,
            };
        }
    }
}