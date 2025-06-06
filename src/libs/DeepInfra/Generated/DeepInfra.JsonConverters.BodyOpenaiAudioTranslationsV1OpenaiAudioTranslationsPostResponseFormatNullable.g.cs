#nullable enable

namespace DeepInfra.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat?>
    {
        /// <inheritdoc />
        public override global::DeepInfra.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::DeepInfra.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepInfra.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepInfra.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DeepInfra.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
