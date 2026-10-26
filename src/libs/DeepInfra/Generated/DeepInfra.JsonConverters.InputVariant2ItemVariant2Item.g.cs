#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DeepInfra.JsonConverters
{
    /// <inheritdoc />
    public class InputVariant2ItemVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.InputVariant2ItemVariant2Item>
    {
        /// <inheritdoc />
        public override global::DeepInfra.InputVariant2ItemVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::DeepInfra.ChatCompletionContentPartText? text = default;
            if (discriminator?.Type == global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.ChatCompletionContentPartText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DeepInfra.ChatCompletionContentPartImage? imageUrl = default;
            if (discriminator?.Type == global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.ChatCompletionContentPartImage)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DeepInfra.ChatCompletionContentPartAudio? inputAudio = default;
            if (discriminator?.Type == global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType.InputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.ChatCompletionContentPartAudio)}");
                inputAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DeepInfra.ChatCompletionContentPartAudioURL? audioUrl = default;
            if (discriminator?.Type == global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType.AudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartAudioURL), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartAudioURL> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.ChatCompletionContentPartAudioURL)}");
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DeepInfra.ChatCompletionContentPartVideo? videoUrl = default;
            if (discriminator?.Type == global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType.VideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.ChatCompletionContentPartVideo)}");
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::DeepInfra.InputVariant2ItemVariant2Item(
                discriminator?.Type,
                text,

                imageUrl,

                inputAudio,

                audioUrl,

                videoUrl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.InputVariant2ItemVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.ChatCompletionContentPartText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.ChatCompletionContentPartImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImageUrl(), typeInfo);
            }
            else if (value.IsInputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.ChatCompletionContentPartAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudio(), typeInfo);
            }
            else if (value.IsAudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartAudioURL), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartAudioURL?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.ChatCompletionContentPartAudioURL).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAudioUrl(), typeInfo);
            }
            else if (value.IsVideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChatCompletionContentPartVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChatCompletionContentPartVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.ChatCompletionContentPartVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVideoUrl(), typeInfo);
            }
        }
    }
}