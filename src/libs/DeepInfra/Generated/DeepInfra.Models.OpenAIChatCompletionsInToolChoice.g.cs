
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIChatCompletionsInToolChoice
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
    public static class OpenAIChatCompletionsInToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatCompletionsInToolChoice value)
        {
            return value switch
            {
                OpenAIChatCompletionsInToolChoice.Auto => "auto",
                OpenAIChatCompletionsInToolChoice.None => "none",
                OpenAIChatCompletionsInToolChoice.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatCompletionsInToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "auto" => OpenAIChatCompletionsInToolChoice.Auto,
                "none" => OpenAIChatCompletionsInToolChoice.None,
                "required" => OpenAIChatCompletionsInToolChoice.Required,
                _ => null,
            };
        }
    }
}