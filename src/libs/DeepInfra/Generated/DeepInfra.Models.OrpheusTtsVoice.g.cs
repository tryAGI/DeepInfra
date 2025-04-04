
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Select the desired voice for the speech output.
    /// </summary>
    public enum OrpheusTtsVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Tara,
        /// <summary>
        /// 
        /// </summary>
        Leah,
        /// <summary>
        /// 
        /// </summary>
        Jess,
        /// <summary>
        /// 
        /// </summary>
        Leo,
        /// <summary>
        /// 
        /// </summary>
        Dan,
        /// <summary>
        /// 
        /// </summary>
        Mia,
        /// <summary>
        /// 
        /// </summary>
        Zac,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrpheusTtsVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrpheusTtsVoice value)
        {
            return value switch
            {
                OrpheusTtsVoice.Tara => "tara",
                OrpheusTtsVoice.Leah => "leah",
                OrpheusTtsVoice.Jess => "jess",
                OrpheusTtsVoice.Leo => "leo",
                OrpheusTtsVoice.Dan => "dan",
                OrpheusTtsVoice.Mia => "mia",
                OrpheusTtsVoice.Zac => "zac",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrpheusTtsVoice? ToEnum(string value)
        {
            return value switch
            {
                "tara" => OrpheusTtsVoice.Tara,
                "leah" => OrpheusTtsVoice.Leah,
                "jess" => OrpheusTtsVoice.Jess,
                "leo" => OrpheusTtsVoice.Leo,
                "dan" => OrpheusTtsVoice.Dan,
                "mia" => OrpheusTtsVoice.Mia,
                "zac" => OrpheusTtsVoice.Zac,
                _ => null,
            };
        }
    }
}