
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicThinkingConfigType2
    {
        /// <summary>
        ///
        /// </summary>
        Adaptive,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkingConfigType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingConfigType2 value)
        {
            return value switch
            {
                AnthropicThinkingConfigType2.Adaptive => "adaptive",
                AnthropicThinkingConfigType2.Disabled => "disabled",
                AnthropicThinkingConfigType2.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingConfigType2? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => AnthropicThinkingConfigType2.Adaptive,
                "disabled" => AnthropicThinkingConfigType2.Disabled,
                "enabled" => AnthropicThinkingConfigType2.Enabled,
                _ => null,
            };
        }
    }
}