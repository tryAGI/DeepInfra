#nullable enable

namespace DeepInfra.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAIImagesResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.OpenAIImagesResponseFormat>
    {
        /// <inheritdoc />
        public override global::DeepInfra.OpenAIImagesResponseFormat Read(
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
                        return global::DeepInfra.OpenAIImagesResponseFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepInfra.OpenAIImagesResponseFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepInfra.OpenAIImagesResponseFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.OpenAIImagesResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DeepInfra.OpenAIImagesResponseFormatExtensions.ToValueString(value));
        }
    }
}
