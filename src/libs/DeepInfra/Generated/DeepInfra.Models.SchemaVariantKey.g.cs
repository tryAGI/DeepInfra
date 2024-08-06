
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum SchemaVariantKey
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompletions,
        /// <summary>
        /// 
        /// </summary>
        OpenaiChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        OpenaiEmbeddings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemaVariantKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaVariantKey value)
        {
            return value switch
            {
                SchemaVariantKey.Default => "default",
                SchemaVariantKey.OpenaiCompletions => "openai-completions",
                SchemaVariantKey.OpenaiChatCompletions => "openai-chat-completions",
                SchemaVariantKey.OpenaiEmbeddings => "openai-embeddings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaVariantKey? ToEnum(string value)
        {
            return value switch
            {
                "default" => SchemaVariantKey.Default,
                "openai-completions" => SchemaVariantKey.OpenaiCompletions,
                "openai-chat-completions" => SchemaVariantKey.OpenaiChatCompletions,
                "openai-embeddings" => SchemaVariantKey.OpenaiEmbeddings,
                _ => null,
            };
        }
    }
}