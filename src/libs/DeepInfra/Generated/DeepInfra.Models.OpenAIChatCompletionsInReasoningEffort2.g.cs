
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIChatCompletionsInReasoningEffort2
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
    public static class OpenAIChatCompletionsInReasoningEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatCompletionsInReasoningEffort2 value)
        {
            return value switch
            {
                OpenAIChatCompletionsInReasoningEffort2.High => "high",
                OpenAIChatCompletionsInReasoningEffort2.Low => "low",
                OpenAIChatCompletionsInReasoningEffort2.Max => "max",
                OpenAIChatCompletionsInReasoningEffort2.Medium => "medium",
                OpenAIChatCompletionsInReasoningEffort2.Minimal => "minimal",
                OpenAIChatCompletionsInReasoningEffort2.None => "none",
                OpenAIChatCompletionsInReasoningEffort2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatCompletionsInReasoningEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => OpenAIChatCompletionsInReasoningEffort2.High,
                "low" => OpenAIChatCompletionsInReasoningEffort2.Low,
                "max" => OpenAIChatCompletionsInReasoningEffort2.Max,
                "medium" => OpenAIChatCompletionsInReasoningEffort2.Medium,
                "minimal" => OpenAIChatCompletionsInReasoningEffort2.Minimal,
                "none" => OpenAIChatCompletionsInReasoningEffort2.None,
                "xhigh" => OpenAIChatCompletionsInReasoningEffort2.Xhigh,
                _ => null,
            };
        }
    }
}