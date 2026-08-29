
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType.ImageUrl => "image_url",
                OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType.ImageUrl,
                "text" => OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}