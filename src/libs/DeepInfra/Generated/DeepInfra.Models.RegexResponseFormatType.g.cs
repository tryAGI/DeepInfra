
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Default Value: regex
    /// </summary>
    public enum RegexResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegexResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegexResponseFormatType value)
        {
            return value switch
            {
                RegexResponseFormatType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegexResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "regex" => RegexResponseFormatType.Regex,
                _ => null,
            };
        }
    }
}