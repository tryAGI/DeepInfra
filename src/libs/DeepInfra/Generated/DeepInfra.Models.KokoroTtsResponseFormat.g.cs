
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Select the desired format for the speech output. Supported formats include mp3, opus, flac, wav, and pcm.
    /// </summary>
    public enum KokoroTtsResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Wav,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KokoroTtsResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KokoroTtsResponseFormat value)
        {
            return value switch
            {
                KokoroTtsResponseFormat.Mp3 => "mp3",
                KokoroTtsResponseFormat.Opus => "opus",
                KokoroTtsResponseFormat.Flac => "flac",
                KokoroTtsResponseFormat.Wav => "wav",
                KokoroTtsResponseFormat.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KokoroTtsResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => KokoroTtsResponseFormat.Mp3,
                "opus" => KokoroTtsResponseFormat.Opus,
                "flac" => KokoroTtsResponseFormat.Flac,
                "wav" => KokoroTtsResponseFormat.Wav,
                "pcm" => KokoroTtsResponseFormat.Pcm,
                _ => null,
            };
        }
    }
}