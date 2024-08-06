#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKeyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey>
    {
        /// <inheritdoc />
        public override global::DeepInfra.ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey Read(
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
                        return global::DeepInfra.ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKeyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepInfra.ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKey value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DeepInfra.ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKeyExtensions.ToValueString(value));
        }
    }
}
