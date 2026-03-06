
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Default Value: json_object
    /// </summary>
    public enum JsonObjectResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JsonObjectResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonObjectResponseFormatType value)
        {
            return value switch
            {
                JsonObjectResponseFormatType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonObjectResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => JsonObjectResponseFormatType.JsonObject,
                _ => null,
            };
        }
    }
}