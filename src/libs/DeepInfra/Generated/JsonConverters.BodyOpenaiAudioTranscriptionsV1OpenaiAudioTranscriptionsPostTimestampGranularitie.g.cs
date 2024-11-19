#nullable enable

namespace DeepInfra.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitieJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitie>
    {
        /// <inheritdoc />
        public override global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitie Read(
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
                        return global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitieExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitie)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitie value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitieExtensions.ToValueString(value));
        }
    }
}