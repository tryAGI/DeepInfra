#nullable enable

namespace DeepInfra.JsonConverters
{
    /// <inheritdoc />
    public sealed class StandardArgsQuantizationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.StandardArgsQuantization>
    {
        /// <inheritdoc />
        public override global::DeepInfra.StandardArgsQuantization Read(
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
                        return global::DeepInfra.StandardArgsQuantizationExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepInfra.StandardArgsQuantization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepInfra.StandardArgsQuantization);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.StandardArgsQuantization value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DeepInfra.StandardArgsQuantizationExtensions.ToValueString(value));
        }
    }
}
