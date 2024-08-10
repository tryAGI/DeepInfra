
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ElevenLabsTextToSpeechInModelId
    {
        /// <summary>
        /// 
        /// </summary>
        DeepinfraTts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsTextToSpeechInModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsTextToSpeechInModelId value)
        {
            return value switch
            {
                ElevenLabsTextToSpeechInModelId.DeepinfraTts => "deepinfra/tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsTextToSpeechInModelId? ToEnum(string value)
        {
            return value switch
            {
                "deepinfra/tts" => ElevenLabsTextToSpeechInModelId.DeepinfraTts,
                _ => null,
            };
        }
    }
}