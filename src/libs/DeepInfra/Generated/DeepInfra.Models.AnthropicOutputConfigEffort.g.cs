
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicOutputConfigEffort
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicOutputConfigEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicOutputConfigEffort value)
        {
            return value switch
            {
                AnthropicOutputConfigEffort.High => "high",
                AnthropicOutputConfigEffort.Low => "low",
                AnthropicOutputConfigEffort.Max => "max",
                AnthropicOutputConfigEffort.Medium => "medium",
                AnthropicOutputConfigEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicOutputConfigEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => AnthropicOutputConfigEffort.High,
                "low" => AnthropicOutputConfigEffort.Low,
                "max" => AnthropicOutputConfigEffort.Max,
                "medium" => AnthropicOutputConfigEffort.Medium,
                "xhigh" => AnthropicOutputConfigEffort.Xhigh,
                _ => null,
            };
        }
    }
}