
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum PresetConfigOutStandardArgsKvCacheDtype
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Fp8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PresetConfigOutStandardArgsKvCacheDtypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresetConfigOutStandardArgsKvCacheDtype value)
        {
            return value switch
            {
                PresetConfigOutStandardArgsKvCacheDtype.Auto => "auto",
                PresetConfigOutStandardArgsKvCacheDtype.Fp8 => "fp8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresetConfigOutStandardArgsKvCacheDtype? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PresetConfigOutStandardArgsKvCacheDtype.Auto,
                "fp8" => PresetConfigOutStandardArgsKvCacheDtype.Fp8,
                _ => null,
            };
        }
    }
}