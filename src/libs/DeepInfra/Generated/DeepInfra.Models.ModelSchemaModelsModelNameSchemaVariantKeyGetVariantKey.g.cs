
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey
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
    public static class ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey value)
        {
            return value switch
            {
                ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey.Default => "default",
                ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey.OpenaiCompletions => "openai-completions",
                ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey.OpenaiChatCompletions => "openai-chat-completions",
                ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey.OpenaiEmbeddings => "openai-embeddings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey? ToEnum(string value)
        {
            return value switch
            {
                "default" => ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey.Default,
                "openai-completions" => ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey.OpenaiCompletions,
                "openai-chat-completions" => ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey.OpenaiChatCompletions,
                "openai-embeddings" => ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey.OpenaiEmbeddings,
                _ => null,
            };
        }
    }
}