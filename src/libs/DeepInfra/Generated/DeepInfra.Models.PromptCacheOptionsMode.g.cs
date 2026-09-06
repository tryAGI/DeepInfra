
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptCacheOptionsMode
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
    public static class PromptCacheOptionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheOptionsMode value)
        {
            return value switch
            {
                PromptCacheOptionsMode.Explicit => "explicit",
                PromptCacheOptionsMode.Implicit => "implicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheOptionsMode? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => PromptCacheOptionsMode.Explicit,
                "implicit" => PromptCacheOptionsMode.Implicit,
                _ => null,
            };
        }
    }
}