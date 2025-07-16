
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum ResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatType value)
        {
            return value switch
            {
                ResponseFormatType.Text => "text",
                ResponseFormatType.JsonObject => "json_object",
                ResponseFormatType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseFormatType.Text,
                "json_object" => ResponseFormatType.JsonObject,
                "json_schema" => ResponseFormatType.JsonSchema,
                _ => null,
            };
        }
    }
}