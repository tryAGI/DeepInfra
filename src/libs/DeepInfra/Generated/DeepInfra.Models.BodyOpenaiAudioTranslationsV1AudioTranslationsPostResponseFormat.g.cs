
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    public enum BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat
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
    public static class BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat value)
        {
            return value switch
            {
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.Json => "json",
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.VerboseJson => "verbose_json",
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.Text => "text",
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.Srt => "srt",
                BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.Json,
                "verbose_json" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.VerboseJson,
                "text" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.Text,
                "srt" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.Srt,
                "vtt" => BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}