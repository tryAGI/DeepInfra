
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
        /// <summary>
        /// 
        /// </summary>
        CreateVoice,
        /// <summary>
        /// 
        /// </summary>
        ReadVoice,
        /// <summary>
        /// 
        /// </summary>
        UpdateVoice,
        /// <summary>
        /// 
        /// </summary>
        DeleteVoice,
        /// <summary>
        /// 
        /// </summary>
        ListVoices,
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
                SchemaVariantKey.CreateVoice => "create-voice",
                SchemaVariantKey.ReadVoice => "read-voice",
                SchemaVariantKey.UpdateVoice => "update-voice",
                SchemaVariantKey.DeleteVoice => "delete-voice",
                SchemaVariantKey.ListVoices => "list-voices",
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
                "create-voice" => SchemaVariantKey.CreateVoice,
                "read-voice" => SchemaVariantKey.ReadVoice,
                "update-voice" => SchemaVariantKey.UpdateVoice,
                "delete-voice" => SchemaVariantKey.DeleteVoice,
                "list-voices" => SchemaVariantKey.ListVoices,
                _ => null,
            };
        }
    }
}