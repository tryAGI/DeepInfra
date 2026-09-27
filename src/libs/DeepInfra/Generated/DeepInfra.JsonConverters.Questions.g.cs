#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DeepInfra.JsonConverters
{
    /// <inheritdoc />
    public class QuestionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.Questions>
    {
        /// <inheritdoc />
        public override global::DeepInfra.Questions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.SystemOneRequestQuestionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.SystemOneRequestQuestionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.SystemOneRequestQuestionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::DeepInfra.NoulQuestion? noul = default;
            if (discriminator?.Type == global::DeepInfra.SystemOneRequestQuestionsDiscriminatorType.Noul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.NoulQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.NoulQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.NoulQuestion)}");
                noul = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DeepInfra.ChoiceQuestion? choice = default;
            if (discriminator?.Type == global::DeepInfra.SystemOneRequestQuestionsDiscriminatorType.Choice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChoiceQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChoiceQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.ChoiceQuestion)}");
                choice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DeepInfra.ScoreQuestion? score = default;
            if (discriminator?.Type == global::DeepInfra.SystemOneRequestQuestionsDiscriminatorType.Score)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ScoreQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ScoreQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.ScoreQuestion)}");
                score = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::DeepInfra.Questions(
                discriminator?.Type,
                noul,

                choice,

                score
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.Questions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNoul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.NoulQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.NoulQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.NoulQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Noul!, typeInfo);
            }
            else if (value.IsChoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ChoiceQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ChoiceQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.ChoiceQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Choice!, typeInfo);
            }
            else if (value.IsScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.ScoreQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.ScoreQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.ScoreQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Score!, typeInfo);
            }
        }
    }
}