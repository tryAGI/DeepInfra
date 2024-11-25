
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::DeepInfra.JsonConverters.SuspendReasonJsonConverter),
            typeof(global::DeepInfra.JsonConverters.SuspendReasonNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormatJsonConverter),
            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormatNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitieJsonConverter),
            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitieNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatJsonConverter),
            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormatNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionAssistantMessageRoleJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionAssistantMessageRoleNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionContentPartImageTypeJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionContentPartImageTypeNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ImageURLDetailJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ImageURLDetailNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionContentPartTextTypeJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionContentPartTextTypeNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionSystemMessageRoleJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionSystemMessageRoleNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionToolMessageRoleJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionToolMessageRoleNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionUserMessageRoleJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ChatCompletionUserMessageRoleNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.SourceTypeEnumJsonConverter),
            typeof(global::DeepInfra.JsonConverters.SourceTypeEnumNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.DeployGPUsJsonConverter),
            typeof(global::DeepInfra.JsonConverters.DeployGPUsNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ModelProviderJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ModelProviderNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.DeployTypeJsonConverter),
            typeof(global::DeepInfra.JsonConverters.DeployTypeNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.TtsResponseFormatJsonConverter),
            typeof(global::DeepInfra.JsonConverters.TtsResponseFormatNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.HFTasksEJsonConverter),
            typeof(global::DeepInfra.JsonConverters.HFTasksENullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ModelDocBlockKeyJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ModelDocBlockKeyNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.SchemaVariantKeyJsonConverter),
            typeof(global::DeepInfra.JsonConverters.SchemaVariantKeyNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ResponseFormatTypeJsonConverter),
            typeof(global::DeepInfra.JsonConverters.ResponseFormatTypeNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInEncodingFormatJsonConverter),
            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInEncodingFormatNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.TtsVoiceJsonConverter),
            typeof(global::DeepInfra.JsonConverters.TtsVoiceNullableJsonConverter),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, int?>),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage>>>),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage>),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits>),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits>),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),
            typeof(global::DeepInfra.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}