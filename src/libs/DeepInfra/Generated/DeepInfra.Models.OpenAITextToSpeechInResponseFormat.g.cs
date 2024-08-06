
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum OpenAITextToSpeechInResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAITextToSpeechInResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAITextToSpeechInResponseFormat value)
        {
            return value switch
            {
                OpenAITextToSpeechInResponseFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAITextToSpeechInResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "wav" => OpenAITextToSpeechInResponseFormat.Wav,
                _ => null,
            };
        }
    }
}