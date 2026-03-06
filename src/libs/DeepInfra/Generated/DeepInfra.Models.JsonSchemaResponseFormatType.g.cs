
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Default Value: json_schema
    /// </summary>
    public enum JsonSchemaResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JsonSchemaResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonSchemaResponseFormatType value)
        {
            return value switch
            {
                JsonSchemaResponseFormatType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonSchemaResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => JsonSchemaResponseFormatType.JsonSchema,
                _ => null,
            };
        }
    }
}