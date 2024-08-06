
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// the role of the author of this message<br/>
    /// Default Value: tool
    /// </summary>
    public enum ChatCompletionToolMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionToolMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionToolMessageRole value)
        {
            return value switch
            {
                ChatCompletionToolMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionToolMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ChatCompletionToolMessageRole.Tool,
                _ => null,
            };
        }
    }
}