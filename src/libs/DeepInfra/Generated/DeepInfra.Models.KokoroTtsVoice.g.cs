
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Select the desired voice for the speech output. You can select multiple to combine and mix voices.
    /// </summary>
    public enum KokoroTtsVoice
    {
        /// <summary>
        /// 
        /// </summary>
        AfAlloy,
        /// <summary>
        /// 
        /// </summary>
        AfAoede,
        /// <summary>
        /// 
        /// </summary>
        AfBella,
        /// <summary>
        /// 
        /// </summary>
        AfJessica,
        /// <summary>
        /// 
        /// </summary>
        AfKore,
        /// <summary>
        /// 
        /// </summary>
        AfNicole,
        /// <summary>
        /// 
        /// </summary>
        AfNova,
        /// <summary>
        /// 
        /// </summary>
        AfRiver,
        /// <summary>
        /// 
        /// </summary>
        AfSarah,
        /// <summary>
        /// 
        /// </summary>
        AfSky,
        /// <summary>
        /// 
        /// </summary>
        AmAdam,
        /// <summary>
        /// 
        /// </summary>
        AmEcho,
        /// <summary>
        /// 
        /// </summary>
        AmEric,
        /// <summary>
        /// 
        /// </summary>
        AmFenrir,
        /// <summary>
        /// 
        /// </summary>
        AmLiam,
        /// <summary>
        /// 
        /// </summary>
        AmMichael,
        /// <summary>
        /// 
        /// </summary>
        AmOnyx,
        /// <summary>
        /// 
        /// </summary>
        AmPuck,
        /// <summary>
        /// 
        /// </summary>
        BfAlice,
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
        BfLily,
        /// <summary>
        /// 
        /// </summary>
        BmDaniel,
        /// <summary>
        /// 
        /// </summary>
        BmFable,
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
        FfSiwis,
        /// <summary>
        /// 
        /// </summary>
        HfAlpha,
        /// <summary>
        /// 
        /// </summary>
        HfBeta,
        /// <summary>
        /// 
        /// </summary>
        HmOmega,
        /// <summary>
        /// 
        /// </summary>
        HmPsi,
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
                KokoroTtsVoice.AfAlloy => "af_alloy",
                KokoroTtsVoice.AfAoede => "af_aoede",
                KokoroTtsVoice.AfBella => "af_bella",
                KokoroTtsVoice.AfJessica => "af_jessica",
                KokoroTtsVoice.AfKore => "af_kore",
                KokoroTtsVoice.AfNicole => "af_nicole",
                KokoroTtsVoice.AfNova => "af_nova",
                KokoroTtsVoice.AfRiver => "af_river",
                KokoroTtsVoice.AfSarah => "af_sarah",
                KokoroTtsVoice.AfSky => "af_sky",
                KokoroTtsVoice.AmAdam => "am_adam",
                KokoroTtsVoice.AmEcho => "am_echo",
                KokoroTtsVoice.AmEric => "am_eric",
                KokoroTtsVoice.AmFenrir => "am_fenrir",
                KokoroTtsVoice.AmLiam => "am_liam",
                KokoroTtsVoice.AmMichael => "am_michael",
                KokoroTtsVoice.AmOnyx => "am_onyx",
                KokoroTtsVoice.AmPuck => "am_puck",
                KokoroTtsVoice.BfAlice => "bf_alice",
                KokoroTtsVoice.BfEmma => "bf_emma",
                KokoroTtsVoice.BfIsabella => "bf_isabella",
                KokoroTtsVoice.BfLily => "bf_lily",
                KokoroTtsVoice.BmDaniel => "bm_daniel",
                KokoroTtsVoice.BmFable => "bm_fable",
                KokoroTtsVoice.BmGeorge => "bm_george",
                KokoroTtsVoice.BmLewis => "bm_lewis",
                KokoroTtsVoice.FfSiwis => "ff_siwis",
                KokoroTtsVoice.HfAlpha => "hf_alpha",
                KokoroTtsVoice.HfBeta => "hf_beta",
                KokoroTtsVoice.HmOmega => "hm_omega",
                KokoroTtsVoice.HmPsi => "hm_psi",
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
                "af_alloy" => KokoroTtsVoice.AfAlloy,
                "af_aoede" => KokoroTtsVoice.AfAoede,
                "af_bella" => KokoroTtsVoice.AfBella,
                "af_jessica" => KokoroTtsVoice.AfJessica,
                "af_kore" => KokoroTtsVoice.AfKore,
                "af_nicole" => KokoroTtsVoice.AfNicole,
                "af_nova" => KokoroTtsVoice.AfNova,
                "af_river" => KokoroTtsVoice.AfRiver,
                "af_sarah" => KokoroTtsVoice.AfSarah,
                "af_sky" => KokoroTtsVoice.AfSky,
                "am_adam" => KokoroTtsVoice.AmAdam,
                "am_echo" => KokoroTtsVoice.AmEcho,
                "am_eric" => KokoroTtsVoice.AmEric,
                "am_fenrir" => KokoroTtsVoice.AmFenrir,
                "am_liam" => KokoroTtsVoice.AmLiam,
                "am_michael" => KokoroTtsVoice.AmMichael,
                "am_onyx" => KokoroTtsVoice.AmOnyx,
                "am_puck" => KokoroTtsVoice.AmPuck,
                "bf_alice" => KokoroTtsVoice.BfAlice,
                "bf_emma" => KokoroTtsVoice.BfEmma,
                "bf_isabella" => KokoroTtsVoice.BfIsabella,
                "bf_lily" => KokoroTtsVoice.BfLily,
                "bm_daniel" => KokoroTtsVoice.BmDaniel,
                "bm_fable" => KokoroTtsVoice.BmFable,
                "bm_george" => KokoroTtsVoice.BmGeorge,
                "bm_lewis" => KokoroTtsVoice.BmLewis,
                "ff_siwis" => KokoroTtsVoice.FfSiwis,
                "hf_alpha" => KokoroTtsVoice.HfAlpha,
                "hf_beta" => KokoroTtsVoice.HfBeta,
                "hm_omega" => KokoroTtsVoice.HmOmega,
                "hm_psi" => KokoroTtsVoice.HmPsi,
                _ => null,
            };
        }
    }
}