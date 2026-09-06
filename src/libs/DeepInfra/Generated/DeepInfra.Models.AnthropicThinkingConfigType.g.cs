
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicThinkingConfigType
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
    public static class AnthropicThinkingConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingConfigType value)
        {
            return value switch
            {
                AnthropicThinkingConfigType.Adaptive => "adaptive",
                AnthropicThinkingConfigType.Disabled => "disabled",
                AnthropicThinkingConfigType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingConfigType? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => AnthropicThinkingConfigType.Adaptive,
                "disabled" => AnthropicThinkingConfigType.Disabled,
                "enabled" => AnthropicThinkingConfigType.Enabled,
                _ => null,
            };
        }
    }
}