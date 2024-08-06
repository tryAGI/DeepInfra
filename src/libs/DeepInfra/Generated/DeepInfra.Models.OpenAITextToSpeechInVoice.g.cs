
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum OpenAITextToSpeechInVoice
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
    public static class OpenAITextToSpeechInVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAITextToSpeechInVoice value)
        {
            return value switch
            {
                OpenAITextToSpeechInVoice.Luna => "luna",
                OpenAITextToSpeechInVoice.Aura => "aura",
                OpenAITextToSpeechInVoice.Quartz => "quartz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAITextToSpeechInVoice? ToEnum(string value)
        {
            return value switch
            {
                "luna" => OpenAITextToSpeechInVoice.Luna,
                "aura" => OpenAITextToSpeechInVoice.Aura,
                "quartz" => OpenAITextToSpeechInVoice.Quartz,
                _ => null,
            };
        }
    }
}