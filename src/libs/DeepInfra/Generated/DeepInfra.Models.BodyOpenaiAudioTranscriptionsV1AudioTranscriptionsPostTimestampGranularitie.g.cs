
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitie
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
        /// <summary>
        /// 
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitie value)
        {
            return value switch
            {
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitie.Segment => "segment",
                BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitie.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitie? ToEnum(string value)
        {
            return value switch
            {
                "segment" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitie.Segment,
                "word" => BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitie.Word,
                _ => null,
            };
        }
    }
}