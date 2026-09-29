
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Default Value: summary_text
    /// </summary>
    public enum ReasoningSummaryPartType
    {
        /// <summary>
        ///
        /// </summary>
        ReasoningText,
        /// <summary>
        ///
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningSummaryPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningSummaryPartType value)
        {
            return value switch
            {
                ReasoningSummaryPartType.ReasoningText => "reasoning_text",
                ReasoningSummaryPartType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningSummaryPartType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning_text" => ReasoningSummaryPartType.ReasoningText,
                "summary_text" => ReasoningSummaryPartType.SummaryText,
                _ => null,
            };
        }
    }
}