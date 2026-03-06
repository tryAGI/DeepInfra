
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum TextResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextResponseFormatType value)
        {
            return value switch
            {
                TextResponseFormatType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextResponseFormatType.Text,
                _ => null,
            };
        }
    }
}