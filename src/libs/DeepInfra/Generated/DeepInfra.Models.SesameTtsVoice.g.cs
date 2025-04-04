
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Select the desired voice for the speech output.
    /// </summary>
    public enum SesameTtsVoice
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationalA,
        /// <summary>
        /// 
        /// </summary>
        ConversationalB,
        /// <summary>
        /// 
        /// </summary>
        ReadSpeechA,
        /// <summary>
        /// 
        /// </summary>
        ReadSpeechB,
        /// <summary>
        /// 
        /// </summary>
        ReadSpeechC,
        /// <summary>
        /// 
        /// </summary>
        ReadSpeechD,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SesameTtsVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SesameTtsVoice value)
        {
            return value switch
            {
                SesameTtsVoice.ConversationalA => "conversational_a",
                SesameTtsVoice.ConversationalB => "conversational_b",
                SesameTtsVoice.ReadSpeechA => "read_speech_a",
                SesameTtsVoice.ReadSpeechB => "read_speech_b",
                SesameTtsVoice.ReadSpeechC => "read_speech_c",
                SesameTtsVoice.ReadSpeechD => "read_speech_d",
                SesameTtsVoice.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SesameTtsVoice? ToEnum(string value)
        {
            return value switch
            {
                "conversational_a" => SesameTtsVoice.ConversationalA,
                "conversational_b" => SesameTtsVoice.ConversationalB,
                "read_speech_a" => SesameTtsVoice.ReadSpeechA,
                "read_speech_b" => SesameTtsVoice.ReadSpeechB,
                "read_speech_c" => SesameTtsVoice.ReadSpeechC,
                "read_speech_d" => SesameTtsVoice.ReadSpeechD,
                "none" => SesameTtsVoice.None,
                _ => null,
            };
        }
    }
}