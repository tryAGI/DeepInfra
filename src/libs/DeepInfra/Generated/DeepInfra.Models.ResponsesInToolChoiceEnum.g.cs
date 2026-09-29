
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesInToolChoiceEnum
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesInToolChoiceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesInToolChoiceEnum value)
        {
            return value switch
            {
                ResponsesInToolChoiceEnum.Auto => "auto",
                ResponsesInToolChoiceEnum.None => "none",
                ResponsesInToolChoiceEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesInToolChoiceEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponsesInToolChoiceEnum.Auto,
                "none" => ResponsesInToolChoiceEnum.None,
                "required" => ResponsesInToolChoiceEnum.Required,
                _ => null,
            };
        }
    }
}