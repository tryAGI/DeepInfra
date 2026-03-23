
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// format used when encoding<br/>
    /// Default Value: float
    /// </summary>
    public enum OpenAIEmbeddingsInEncodingFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Float,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIEmbeddingsInEncodingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIEmbeddingsInEncodingFormat value)
        {
            return value switch
            {
                OpenAIEmbeddingsInEncodingFormat.Base64 => "base64",
                OpenAIEmbeddingsInEncodingFormat.Float => "float",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIEmbeddingsInEncodingFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => OpenAIEmbeddingsInEncodingFormat.Base64,
                "float" => OpenAIEmbeddingsInEncodingFormat.Float,
                _ => null,
            };
        }
    }
}