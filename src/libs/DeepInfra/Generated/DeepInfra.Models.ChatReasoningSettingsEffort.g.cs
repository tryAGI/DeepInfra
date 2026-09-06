
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatReasoningSettingsEffort
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
    public static class ChatReasoningSettingsEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatReasoningSettingsEffort value)
        {
            return value switch
            {
                ChatReasoningSettingsEffort.High => "high",
                ChatReasoningSettingsEffort.Low => "low",
                ChatReasoningSettingsEffort.Max => "max",
                ChatReasoningSettingsEffort.Medium => "medium",
                ChatReasoningSettingsEffort.Minimal => "minimal",
                ChatReasoningSettingsEffort.None => "none",
                ChatReasoningSettingsEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatReasoningSettingsEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatReasoningSettingsEffort.High,
                "low" => ChatReasoningSettingsEffort.Low,
                "max" => ChatReasoningSettingsEffort.Max,
                "medium" => ChatReasoningSettingsEffort.Medium,
                "minimal" => ChatReasoningSettingsEffort.Minimal,
                "none" => ChatReasoningSettingsEffort.None,
                "xhigh" => ChatReasoningSettingsEffort.Xhigh,
                _ => null,
            };
        }
    }
}