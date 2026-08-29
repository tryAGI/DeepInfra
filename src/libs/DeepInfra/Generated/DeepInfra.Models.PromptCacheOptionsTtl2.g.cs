
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptCacheOptionsTtl2
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
    public static class PromptCacheOptionsTtl2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheOptionsTtl2 value)
        {
            return value switch
            {
                PromptCacheOptionsTtl2.x1h => "1h",
                PromptCacheOptionsTtl2.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheOptionsTtl2? ToEnum(string value)
        {
            return value switch
            {
                "1h" => PromptCacheOptionsTtl2.x1h,
                "5m" => PromptCacheOptionsTtl2.x5m,
                _ => null,
            };
        }
    }
}