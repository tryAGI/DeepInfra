#nullable enable

namespace DeepInfra.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptCacheOptionsModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.PromptCacheOptionsMode>
    {
        /// <inheritdoc />
        public override global::DeepInfra.PromptCacheOptionsMode Read(
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
                        return global::DeepInfra.PromptCacheOptionsModeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepInfra.PromptCacheOptionsMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepInfra.PromptCacheOptionsMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.PromptCacheOptionsMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DeepInfra.PromptCacheOptionsModeExtensions.ToValueString(value));
        }
    }
}
