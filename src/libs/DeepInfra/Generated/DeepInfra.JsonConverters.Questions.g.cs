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
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion? noul = default;
            if (discriminator?.Type == global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType.Noul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion)}");
                noul = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion? choice = default;
            if (discriminator?.Type == global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType.Choice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion)}");
                choice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion? score = default;
            if (discriminator?.Type == global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType.Score)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion)}");
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNoul(), typeInfo);
            }
            else if (value.IsChoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickChoice(), typeInfo);
            }
            else if (value.IsScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScore(), typeInfo);
            }
        }
    }
}