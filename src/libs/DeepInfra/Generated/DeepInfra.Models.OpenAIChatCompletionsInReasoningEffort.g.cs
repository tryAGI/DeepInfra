
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIChatCompletionsInReasoningEffort
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
    public static class OpenAIChatCompletionsInReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatCompletionsInReasoningEffort value)
        {
            return value switch
            {
                OpenAIChatCompletionsInReasoningEffort.High => "high",
                OpenAIChatCompletionsInReasoningEffort.Low => "low",
                OpenAIChatCompletionsInReasoningEffort.Max => "max",
                OpenAIChatCompletionsInReasoningEffort.Medium => "medium",
                OpenAIChatCompletionsInReasoningEffort.Minimal => "minimal",
                OpenAIChatCompletionsInReasoningEffort.None => "none",
                OpenAIChatCompletionsInReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatCompletionsInReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => OpenAIChatCompletionsInReasoningEffort.High,
                "low" => OpenAIChatCompletionsInReasoningEffort.Low,
                "max" => OpenAIChatCompletionsInReasoningEffort.Max,
                "medium" => OpenAIChatCompletionsInReasoningEffort.Medium,
                "minimal" => OpenAIChatCompletionsInReasoningEffort.Minimal,
                "none" => OpenAIChatCompletionsInReasoningEffort.None,
                "xhigh" => OpenAIChatCompletionsInReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}