
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIEmbeddingsInInputType2
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
    public static class OpenAIEmbeddingsInInputType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIEmbeddingsInInputType2 value)
        {
            return value switch
            {
                OpenAIEmbeddingsInInputType2.Document => "document",
                OpenAIEmbeddingsInInputType2.Passage => "passage",
                OpenAIEmbeddingsInInputType2.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIEmbeddingsInInputType2? ToEnum(string value)
        {
            return value switch
            {
                "document" => OpenAIEmbeddingsInInputType2.Document,
                "passage" => OpenAIEmbeddingsInInputType2.Passage,
                "query" => OpenAIEmbeddingsInInputType2.Query,
                _ => null,
            };
        }
    }
}