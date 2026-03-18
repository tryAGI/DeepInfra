
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

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1ItemJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1ItemNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitiesVariant1ItemJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitiesVariant1ItemNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIImagesResponseFormatJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIImagesResponseFormatNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.InputAudioFormatJsonConverter),

            typeof(global::DeepInfra.JsonConverters.InputAudioFormatNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ImageURLDetailJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ImageURLDetailNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ChatReasoningSettingsEffort2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.ChatReasoningSettingsEffort2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ContainerRentalStateOutJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ContainerRentalStateOutNullableJsonConverter),

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

            typeof(global::DeepInfra.JsonConverters.HardwareOptionTypeJsonConverter),

            typeof(global::DeepInfra.JsonConverters.HardwareOptionTypeNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ModelDocBlockKeyJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ModelDocBlockKeyNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.PricingTypeJsonConverter),

            typeof(global::DeepInfra.JsonConverters.PricingTypeNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.SchemaVariantKeyJsonConverter),

            typeof(global::DeepInfra.JsonConverters.SchemaVariantKeyNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIBatchesInEndpointJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIBatchesInEndpointNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIChatCompletionsInReasoningEffort2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIChatCompletionsInReasoningEffort2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ServiceTierJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ServiceTierNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInEncodingFormatJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInEncodingFormatNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ContainerRentalsListV1ContainersGetStateJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ContainerRentalsListV1ContainersGetStateNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.HardwarePricingServerless, global::DeepInfra.HardwarePricingDedicated>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::DeepInfra.ChatTools, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::DeepInfra.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AddFundsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BillingPortalOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.Checklist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SuspendReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ConfigIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ConfigOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeepStartApplicationIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeepStartApplicationOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DiscountMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TimeInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TopUpIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.UsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.UsageMonth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.UsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.UsageOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.UsageMonth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.UsageRentOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicMessagesIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicSystemContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicTokenCountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ApiToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ApiTokenIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ApiTokenVercelExportIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyCreateVoiceV1VoicesAddPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitiesVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiFilesV1FilesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiFilesV1OpenaiFilesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiImagesEditsV1ImagesEditsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesEditsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiImagesEditsV1OpenaiImagesEditsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiImagesVariationsV1ImagesVariationsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesVariationsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiImagesVariationsV1OpenaiImagesVariationsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyUpdateVoiceV1VoicesVoiceIdEditPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputAudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ImageURLDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatReasoningSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatReasoningSettingsEffort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.CompletionMultiModalData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalStateOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalStartIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalStartOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalUpdateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.CreateLoraApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SourceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SourceTypeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeepError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployGPUAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.GPUAvailabilityInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.GPUAvailabilityInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployGPUs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployInstances))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployLLMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HFWeights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployLLMIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ScaleSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployLLMUpdateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployModelIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployStatusOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentLogQueryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<byte[]>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentMainStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DetailedDeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.LLMDeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.EmbeddingsDeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TimeDeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DisplayNameIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ElevenLabsTextToSpeechIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TtsResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.EmailsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FAQEntryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FeedbackIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.GetVoicesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.GpuLimitOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.GpuLimitRequestIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HFModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HFTasksE))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwareOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwareOptionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.HardwarePricingServerless, global::DeepInfra.HardwarePricingDedicated>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwarePricingServerless))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwarePricingDedicated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.HardwareOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InspectScopedJWTOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonObjectResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSchemaResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.LogQueryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.LoraModelUploadIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.Me))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.MeVercelConnection2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.MeIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelDocBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelDocBlockKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelFamilyOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.PricingPageSectionOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PricingPageSectionOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PricingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.PricingPageEntryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PricingPageEntryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingInputLength))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingInputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingUptime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingInputCharacterLength))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingImageUnits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingOutputLength))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.FAQEntryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelFieldInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelInfoOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ModelFieldInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ModelDocBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.SchemaVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SchemaVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SchemaVariantKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelMetaIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPublicityIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelVersionOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIBatchesIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIBatchesInEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIChatCompletionsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ChatTools>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::DeepInfra.ChatTools, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TextResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RegexResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.StreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIChatCompletionsInReasoningEffort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAICompletionsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ServiceTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::System.Collections.Generic.IList<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInEncodingFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesGenerationsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.OpenAIImageData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIModelsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.OpenAIModelOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAITextToSpeechIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenRouterDatacenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenRouterModelData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenRouterPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.OpenRouterDatacenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenRouterModelsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.OpenRouterModelData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RateLimitOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RateLimitRequestIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RequestCostItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RequestCostQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RequestCostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.RequestCostItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SchemaOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ScopedJWTIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ScopedJWTOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SshKeyIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SshKeyOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.UpdateLoraApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.WebLiveMetricsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalsListV1ContainersGetState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.DeploymentOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.DeploymentMainStatsOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ModelOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ModelVersionOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ContainerRentalOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ApiToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.SshKeyOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.UsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.UsageMonth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnthropicSystemContent>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnthropicSystemContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnthropicTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.GPUAvailabilityInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<byte[]>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.HardwareOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.PricingPageSectionOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.PricingPageEntryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.FAQEntryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ModelFieldInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ModelDocBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.SchemaVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ChatTools>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.OpenAIImageData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.OpenAIModelOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.OpenRouterDatacenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.OpenRouterModelData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.RequestCostItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.DeploymentOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.DeploymentMainStatsOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ModelOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ModelVersionOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ContainerRentalOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ApiToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.SshKeyOut>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}