#nullable enable

namespace DeepInfra.JsonConverters
{
    /// <inheritdoc />
    public sealed class SesameTtsVoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.SesameTtsVoice>
    {
        /// <inheritdoc />
        public override global::DeepInfra.SesameTtsVoice Read(
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
                        return global::DeepInfra.SesameTtsVoiceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepInfra.SesameTtsVoice)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.SesameTtsVoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DeepInfra.SesameTtsVoiceExtensions.ToValueString(value));
        }
    }
}
