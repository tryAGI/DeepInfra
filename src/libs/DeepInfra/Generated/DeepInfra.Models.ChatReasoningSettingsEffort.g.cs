
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Constrains effort on reasoning for reasoning models.
    /// </summary>
    public enum ChatReasoningSettingsEffort
    {
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
        High,
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
                ChatReasoningSettingsEffort.Low => "low",
                ChatReasoningSettingsEffort.Medium => "medium",
                ChatReasoningSettingsEffort.High => "high",
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
                "low" => ChatReasoningSettingsEffort.Low,
                "medium" => ChatReasoningSettingsEffort.Medium,
                "high" => ChatReasoningSettingsEffort.High,
                _ => null,
            };
        }
    }
}