
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum PresetConfigOutStandardArgsKvCacheDtype2
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
    public static class PresetConfigOutStandardArgsKvCacheDtype2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresetConfigOutStandardArgsKvCacheDtype2 value)
        {
            return value switch
            {
                PresetConfigOutStandardArgsKvCacheDtype2.Auto => "auto",
                PresetConfigOutStandardArgsKvCacheDtype2.Fp8 => "fp8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresetConfigOutStandardArgsKvCacheDtype2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PresetConfigOutStandardArgsKvCacheDtype2.Auto,
                "fp8" => PresetConfigOutStandardArgsKvCacheDtype2.Fp8,
                _ => null,
            };
        }
    }
}