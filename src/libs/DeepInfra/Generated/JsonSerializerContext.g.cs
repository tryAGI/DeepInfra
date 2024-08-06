
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace DeepInfra
{
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::OpenApiGenerator.JsonConverters.SuspendReasonJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SuspendReasonNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionAssistantMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionAssistantMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionContentPartImageTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionContentPartImageTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionContentPartTextTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionContentPartTextTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionSystemMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionSystemMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionToolMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionToolMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionUserMessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ChatCompletionUserMessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployGPUsJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployGPUsNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployLLMConfigGpuJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployLLMConfigGpuNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployLLMInGpuJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployLLMInGpuNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployModelInProviderJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployModelInProviderNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeployTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentOutTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.DeploymentOutTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.HFTasksEJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.HFTasksENullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ImageURLDetailJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ImageURLDetailNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelDocBlockKeyJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelDocBlockKeyNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelMetaInReportedTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelMetaInReportedTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelProviderJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelProviderNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.OpenAIEmbeddingsInEncodingFormatJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.OpenAIEmbeddingsInEncodingFormatNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.OpenAITextToSpeechInVoiceJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.OpenAITextToSpeechInVoiceNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.OpenAITextToSpeechInResponseFormatJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.OpenAITextToSpeechInResponseFormatNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ResponseFormatTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ResponseFormatTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SchemaVariantKeyJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SchemaVariantKeyNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TtsResponseFormatJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TtsResponseFormatNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TtsVoiceJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TtsVoiceNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKeyJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ModelSchemaModelsModelNameSchemaVariantKeyGetVariantKeyNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory6),
            typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory4),
            typeof(global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSerializerContextTypes))]
    internal sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}