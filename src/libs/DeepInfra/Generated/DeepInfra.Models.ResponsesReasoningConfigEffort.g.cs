
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesReasoningConfigEffort
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
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesReasoningConfigEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesReasoningConfigEffort value)
        {
            return value switch
            {
                ResponsesReasoningConfigEffort.High => "high",
                ResponsesReasoningConfigEffort.Low => "low",
                ResponsesReasoningConfigEffort.Max => "max",
                ResponsesReasoningConfigEffort.Medium => "medium",
                ResponsesReasoningConfigEffort.Minimal => "minimal",
                ResponsesReasoningConfigEffort.None => "none",
                ResponsesReasoningConfigEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesReasoningConfigEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ResponsesReasoningConfigEffort.High,
                "low" => ResponsesReasoningConfigEffort.Low,
                "max" => ResponsesReasoningConfigEffort.Max,
                "medium" => ResponsesReasoningConfigEffort.Medium,
                "minimal" => ResponsesReasoningConfigEffort.Minimal,
                "none" => ResponsesReasoningConfigEffort.None,
                "xhigh" => ResponsesReasoningConfigEffort.Xhigh,
                _ => null,
            };
        }
    }
}