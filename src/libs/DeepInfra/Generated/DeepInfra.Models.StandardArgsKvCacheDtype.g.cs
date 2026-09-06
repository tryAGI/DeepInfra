
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum StandardArgsKvCacheDtype
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
    public static class StandardArgsKvCacheDtypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StandardArgsKvCacheDtype value)
        {
            return value switch
            {
                StandardArgsKvCacheDtype.Auto => "auto",
                StandardArgsKvCacheDtype.Fp8 => "fp8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StandardArgsKvCacheDtype? ToEnum(string value)
        {
            return value switch
            {
                "auto" => StandardArgsKvCacheDtype.Auto,
                "fp8" => StandardArgsKvCacheDtype.Fp8,
                _ => null,
            };
        }
    }
}