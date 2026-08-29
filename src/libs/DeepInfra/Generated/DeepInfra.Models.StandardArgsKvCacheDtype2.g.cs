
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum StandardArgsKvCacheDtype2
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
    public static class StandardArgsKvCacheDtype2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StandardArgsKvCacheDtype2 value)
        {
            return value switch
            {
                StandardArgsKvCacheDtype2.Auto => "auto",
                StandardArgsKvCacheDtype2.Fp8 => "fp8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StandardArgsKvCacheDtype2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => StandardArgsKvCacheDtype2.Auto,
                "fp8" => StandardArgsKvCacheDtype2.Fp8,
                _ => null,
            };
        }
    }
}