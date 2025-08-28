#nullable enable

namespace DeepInfra.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat?>
    {
        /// <inheritdoc />
        public override global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat? Read(
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
                        return global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
