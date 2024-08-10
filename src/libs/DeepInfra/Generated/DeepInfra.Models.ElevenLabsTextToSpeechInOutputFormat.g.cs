
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ElevenLabsTextToSpeechInOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsTextToSpeechInOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsTextToSpeechInOutputFormat value)
        {
            return value switch
            {
                ElevenLabsTextToSpeechInOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsTextToSpeechInOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "wav" => ElevenLabsTextToSpeechInOutputFormat.Wav,
                _ => null,
            };
        }
    }
}