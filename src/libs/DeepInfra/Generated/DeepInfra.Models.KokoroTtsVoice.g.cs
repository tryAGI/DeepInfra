
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
        AfHeart,
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
        AmSanta,
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
        EfDora,
        /// <summary>
        /// 
        /// </summary>
        EmAlex,
        /// <summary>
        /// 
        /// </summary>
        EmSanta,
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
        /// <summary>
        /// 
        /// </summary>
        IfSara,
        /// <summary>
        /// 
        /// </summary>
        ImNicola,
        /// <summary>
        /// 
        /// </summary>
        JfAlpha,
        /// <summary>
        /// 
        /// </summary>
        JfGongitsune,
        /// <summary>
        /// 
        /// </summary>
        JfNezumi,
        /// <summary>
        /// 
        /// </summary>
        JfTebukuro,
        /// <summary>
        /// 
        /// </summary>
        JmKumo,
        /// <summary>
        /// 
        /// </summary>
        PfDora,
        /// <summary>
        /// 
        /// </summary>
        PmAlex,
        /// <summary>
        /// 
        /// </summary>
        PmSanta,
        /// <summary>
        /// 
        /// </summary>
        ZfXiaobei,
        /// <summary>
        /// 
        /// </summary>
        ZfXiaoni,
        /// <summary>
        /// 
        /// </summary>
        ZfXiaoxiao,
        /// <summary>
        /// 
        /// </summary>
        ZfXiaoyi,
        /// <summary>
        /// 
        /// </summary>
        ZmYunjian,
        /// <summary>
        /// 
        /// </summary>
        ZmYunxi,
        /// <summary>
        /// 
        /// </summary>
        ZmYunxia,
        /// <summary>
        /// 
        /// </summary>
        ZmYunyang,
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
                KokoroTtsVoice.AfHeart => "af_heart",
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
                KokoroTtsVoice.AmSanta => "am_santa",
                KokoroTtsVoice.BfAlice => "bf_alice",
                KokoroTtsVoice.BfEmma => "bf_emma",
                KokoroTtsVoice.BfIsabella => "bf_isabella",
                KokoroTtsVoice.BfLily => "bf_lily",
                KokoroTtsVoice.BmDaniel => "bm_daniel",
                KokoroTtsVoice.BmFable => "bm_fable",
                KokoroTtsVoice.BmGeorge => "bm_george",
                KokoroTtsVoice.BmLewis => "bm_lewis",
                KokoroTtsVoice.EfDora => "ef_dora",
                KokoroTtsVoice.EmAlex => "em_alex",
                KokoroTtsVoice.EmSanta => "em_santa",
                KokoroTtsVoice.FfSiwis => "ff_siwis",
                KokoroTtsVoice.HfAlpha => "hf_alpha",
                KokoroTtsVoice.HfBeta => "hf_beta",
                KokoroTtsVoice.HmOmega => "hm_omega",
                KokoroTtsVoice.HmPsi => "hm_psi",
                KokoroTtsVoice.IfSara => "if_sara",
                KokoroTtsVoice.ImNicola => "im_nicola",
                KokoroTtsVoice.JfAlpha => "jf_alpha",
                KokoroTtsVoice.JfGongitsune => "jf_gongitsune",
                KokoroTtsVoice.JfNezumi => "jf_nezumi",
                KokoroTtsVoice.JfTebukuro => "jf_tebukuro",
                KokoroTtsVoice.JmKumo => "jm_kumo",
                KokoroTtsVoice.PfDora => "pf_dora",
                KokoroTtsVoice.PmAlex => "pm_alex",
                KokoroTtsVoice.PmSanta => "pm_santa",
                KokoroTtsVoice.ZfXiaobei => "zf_xiaobei",
                KokoroTtsVoice.ZfXiaoni => "zf_xiaoni",
                KokoroTtsVoice.ZfXiaoxiao => "zf_xiaoxiao",
                KokoroTtsVoice.ZfXiaoyi => "zf_xiaoyi",
                KokoroTtsVoice.ZmYunjian => "zm_yunjian",
                KokoroTtsVoice.ZmYunxi => "zm_yunxi",
                KokoroTtsVoice.ZmYunxia => "zm_yunxia",
                KokoroTtsVoice.ZmYunyang => "zm_yunyang",
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
                "af_heart" => KokoroTtsVoice.AfHeart,
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
                "am_santa" => KokoroTtsVoice.AmSanta,
                "bf_alice" => KokoroTtsVoice.BfAlice,
                "bf_emma" => KokoroTtsVoice.BfEmma,
                "bf_isabella" => KokoroTtsVoice.BfIsabella,
                "bf_lily" => KokoroTtsVoice.BfLily,
                "bm_daniel" => KokoroTtsVoice.BmDaniel,
                "bm_fable" => KokoroTtsVoice.BmFable,
                "bm_george" => KokoroTtsVoice.BmGeorge,
                "bm_lewis" => KokoroTtsVoice.BmLewis,
                "ef_dora" => KokoroTtsVoice.EfDora,
                "em_alex" => KokoroTtsVoice.EmAlex,
                "em_santa" => KokoroTtsVoice.EmSanta,
                "ff_siwis" => KokoroTtsVoice.FfSiwis,
                "hf_alpha" => KokoroTtsVoice.HfAlpha,
                "hf_beta" => KokoroTtsVoice.HfBeta,
                "hm_omega" => KokoroTtsVoice.HmOmega,
                "hm_psi" => KokoroTtsVoice.HmPsi,
                "if_sara" => KokoroTtsVoice.IfSara,
                "im_nicola" => KokoroTtsVoice.ImNicola,
                "jf_alpha" => KokoroTtsVoice.JfAlpha,
                "jf_gongitsune" => KokoroTtsVoice.JfGongitsune,
                "jf_nezumi" => KokoroTtsVoice.JfNezumi,
                "jf_tebukuro" => KokoroTtsVoice.JfTebukuro,
                "jm_kumo" => KokoroTtsVoice.JmKumo,
                "pf_dora" => KokoroTtsVoice.PfDora,
                "pm_alex" => KokoroTtsVoice.PmAlex,
                "pm_santa" => KokoroTtsVoice.PmSanta,
                "zf_xiaobei" => KokoroTtsVoice.ZfXiaobei,
                "zf_xiaoni" => KokoroTtsVoice.ZfXiaoni,
                "zf_xiaoxiao" => KokoroTtsVoice.ZfXiaoxiao,
                "zf_xiaoyi" => KokoroTtsVoice.ZfXiaoyi,
                "zm_yunjian" => KokoroTtsVoice.ZmYunjian,
                "zm_yunxi" => KokoroTtsVoice.ZmYunxi,
                "zm_yunxia" => KokoroTtsVoice.ZmYunxia,
                "zm_yunyang" => KokoroTtsVoice.ZmYunyang,
                _ => null,
            };
        }
    }
}