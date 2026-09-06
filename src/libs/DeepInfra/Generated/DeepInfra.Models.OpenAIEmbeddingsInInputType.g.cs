
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIEmbeddingsInInputType
    {
        /// <summary>
        ///
        /// </summary>
        Document,
        /// <summary>
        ///
        /// </summary>
        Passage,
        /// <summary>
        ///
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIEmbeddingsInInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIEmbeddingsInInputType value)
        {
            return value switch
            {
                OpenAIEmbeddingsInInputType.Document => "document",
                OpenAIEmbeddingsInInputType.Passage => "passage",
                OpenAIEmbeddingsInInputType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIEmbeddingsInInputType? ToEnum(string value)
        {
            return value switch
            {
                "document" => OpenAIEmbeddingsInInputType.Document,
                "passage" => OpenAIEmbeddingsInInputType.Passage,
                "query" => OpenAIEmbeddingsInInputType.Query,
                _ => null,
            };
        }
    }
}