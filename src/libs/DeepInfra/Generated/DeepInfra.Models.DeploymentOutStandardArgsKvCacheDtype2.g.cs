
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum DeploymentOutStandardArgsKvCacheDtype2
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
    public static class DeploymentOutStandardArgsKvCacheDtype2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentOutStandardArgsKvCacheDtype2 value)
        {
            return value switch
            {
                DeploymentOutStandardArgsKvCacheDtype2.Auto => "auto",
                DeploymentOutStandardArgsKvCacheDtype2.Fp8 => "fp8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentOutStandardArgsKvCacheDtype2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => DeploymentOutStandardArgsKvCacheDtype2.Auto,
                "fp8" => DeploymentOutStandardArgsKvCacheDtype2.Fp8,
                _ => null,
            };
        }
    }
}