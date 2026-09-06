
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum DeploymentOutStandardArgsKvCacheDtype
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
    public static class DeploymentOutStandardArgsKvCacheDtypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentOutStandardArgsKvCacheDtype value)
        {
            return value switch
            {
                DeploymentOutStandardArgsKvCacheDtype.Auto => "auto",
                DeploymentOutStandardArgsKvCacheDtype.Fp8 => "fp8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentOutStandardArgsKvCacheDtype? ToEnum(string value)
        {
            return value switch
            {
                "auto" => DeploymentOutStandardArgsKvCacheDtype.Auto,
                "fp8" => DeploymentOutStandardArgsKvCacheDtype.Fp8,
                _ => null,
            };
        }
    }
}