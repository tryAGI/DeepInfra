
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum TtsVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Luna,
        /// <summary>
        /// 
        /// </summary>
        Aura,
        /// <summary>
        /// 
        /// </summary>
        Quartz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsVoice value)
        {
            return value switch
            {
                TtsVoice.Luna => "luna",
                TtsVoice.Aura => "aura",
                TtsVoice.Quartz => "quartz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsVoice? ToEnum(string value)
        {
            return value switch
            {
                "luna" => TtsVoice.Luna,
                "aura" => TtsVoice.Aura,
                "quartz" => TtsVoice.Quartz,
                _ => null,
            };
        }
    }
}