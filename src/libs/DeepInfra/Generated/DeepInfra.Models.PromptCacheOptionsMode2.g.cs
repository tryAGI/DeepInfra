
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptCacheOptionsMode2
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
        /// <summary>
        ///
        /// </summary>
        Implicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheOptionsMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheOptionsMode2 value)
        {
            return value switch
            {
                PromptCacheOptionsMode2.Explicit => "explicit",
                PromptCacheOptionsMode2.Implicit => "implicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheOptionsMode2? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => PromptCacheOptionsMode2.Explicit,
                "implicit" => PromptCacheOptionsMode2.Implicit,
                _ => null,
            };
        }
    }
}