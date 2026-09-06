
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptCacheOptionsTtl
    {
        /// <summary>
        ///
        /// </summary>
        x1h,
        /// <summary>
        ///
        /// </summary>
        x5m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheOptionsTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheOptionsTtl value)
        {
            return value switch
            {
                PromptCacheOptionsTtl.x1h => "1h",
                PromptCacheOptionsTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheOptionsTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => PromptCacheOptionsTtl.x1h,
                "5m" => PromptCacheOptionsTtl.x5m,
                _ => null,
            };
        }
    }
}