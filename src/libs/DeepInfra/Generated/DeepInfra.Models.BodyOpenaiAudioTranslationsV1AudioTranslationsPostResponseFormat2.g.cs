
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        VerboseJson,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2 value)
        {
            return value switch
            {
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.Json => "json",
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.Srt => "srt",
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.Text => "text",
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.VerboseJson => "verbose_json",
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2? ToEnum(string value)
        {
            return value switch
            {
                "json" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.Json,
                "srt" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.Srt,
                "text" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.Text,
                "verbose_json" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.VerboseJson,
                "vtt" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2.Vtt,
                _ => null,
            };
        }
    }
}