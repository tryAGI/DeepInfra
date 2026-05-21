
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatReasoningSettingsEffort2
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
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatReasoningSettingsEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatReasoningSettingsEffort2 value)
        {
            return value switch
            {
                ChatReasoningSettingsEffort2.High => "high",
                ChatReasoningSettingsEffort2.Low => "low",
                ChatReasoningSettingsEffort2.Medium => "medium",
                ChatReasoningSettingsEffort2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatReasoningSettingsEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatReasoningSettingsEffort2.High,
                "low" => ChatReasoningSettingsEffort2.Low,
                "medium" => ChatReasoningSettingsEffort2.Medium,
                "xhigh" => ChatReasoningSettingsEffort2.Xhigh,
                _ => null,
            };
        }
    }
}