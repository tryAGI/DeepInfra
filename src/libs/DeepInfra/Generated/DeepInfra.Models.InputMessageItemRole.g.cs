
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum InputMessageItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageItemRole value)
        {
            return value switch
            {
                InputMessageItemRole.Assistant => "assistant",
                InputMessageItemRole.Developer => "developer",
                InputMessageItemRole.System => "system",
                InputMessageItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => InputMessageItemRole.Assistant,
                "developer" => InputMessageItemRole.Developer,
                "system" => InputMessageItemRole.System,
                "user" => InputMessageItemRole.User,
                _ => null,
            };
        }
    }
}