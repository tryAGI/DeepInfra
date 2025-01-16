
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum KokoroTtsVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Af,
        /// <summary>
        /// 
        /// </summary>
        AfBella,
        /// <summary>
        /// 
        /// </summary>
        AfSarah,
        /// <summary>
        /// 
        /// </summary>
        AmAdam,
        /// <summary>
        /// 
        /// </summary>
        AmMichael,
        /// <summary>
        /// 
        /// </summary>
        BfEmma,
        /// <summary>
        /// 
        /// </summary>
        BfIsabella,
        /// <summary>
        /// 
        /// </summary>
        BmGeorge,
        /// <summary>
        /// 
        /// </summary>
        BmLewis,
        /// <summary>
        /// 
        /// </summary>
        AfNicole,
        /// <summary>
        /// 
        /// </summary>
        AfSky,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KokoroTtsVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KokoroTtsVoice value)
        {
            return value switch
            {
                KokoroTtsVoice.Af => "af",
                KokoroTtsVoice.AfBella => "af_bella",
                KokoroTtsVoice.AfSarah => "af_sarah",
                KokoroTtsVoice.AmAdam => "am_adam",
                KokoroTtsVoice.AmMichael => "am_michael",
                KokoroTtsVoice.BfEmma => "bf_emma",
                KokoroTtsVoice.BfIsabella => "bf_isabella",
                KokoroTtsVoice.BmGeorge => "bm_george",
                KokoroTtsVoice.BmLewis => "bm_lewis",
                KokoroTtsVoice.AfNicole => "af_nicole",
                KokoroTtsVoice.AfSky => "af_sky",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KokoroTtsVoice? ToEnum(string value)
        {
            return value switch
            {
                "af" => KokoroTtsVoice.Af,
                "af_bella" => KokoroTtsVoice.AfBella,
                "af_sarah" => KokoroTtsVoice.AfSarah,
                "am_adam" => KokoroTtsVoice.AmAdam,
                "am_michael" => KokoroTtsVoice.AmMichael,
                "bf_emma" => KokoroTtsVoice.BfEmma,
                "bf_isabella" => KokoroTtsVoice.BfIsabella,
                "bm_george" => KokoroTtsVoice.BmGeorge,
                "bm_lewis" => KokoroTtsVoice.BmLewis,
                "af_nicole" => KokoroTtsVoice.AfNicole,
                "af_sky" => KokoroTtsVoice.AfSky,
                _ => null,
            };
        }
    }
}