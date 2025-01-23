
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum OpenAIImagesResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        B64Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIImagesResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIImagesResponseFormat value)
        {
            return value switch
            {
                OpenAIImagesResponseFormat.B64Json => "b64_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIImagesResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "b64_json" => OpenAIImagesResponseFormat.B64Json,
                _ => null,
            };
        }
    }
}