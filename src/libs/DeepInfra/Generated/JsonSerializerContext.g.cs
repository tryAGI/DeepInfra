
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
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverterFactory7),
            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverterFactory4),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}