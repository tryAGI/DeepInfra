
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

            typeof(global::DeepInfra.JsonConverters.AgentInstanceStateJsonConverter),

            typeof(global::DeepInfra.JsonConverters.AgentInstanceStateNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.AnthropicThinkingConfigType2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.AnthropicThinkingConfigType2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1ItemJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1ItemNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ChatReasoningSettingsEffort2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.ChatReasoningSettingsEffort2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ContainerRentalStateOutJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ContainerRentalStateOutNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.DeployGPUsJsonConverter),

            typeof(global::DeepInfra.JsonConverters.DeployGPUsNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.DeployTypeJsonConverter),

            typeof(global::DeepInfra.JsonConverters.DeployTypeNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.DeploymentOutStandardArgsKvCacheDtype2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.DeploymentOutStandardArgsKvCacheDtype2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.DeploymentOutStandardArgsQuantization2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.DeploymentOutStandardArgsQuantization2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.HFTasksEJsonConverter),

            typeof(global::DeepInfra.JsonConverters.HFTasksENullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.HardwareOptionTypeJsonConverter),

            typeof(global::DeepInfra.JsonConverters.HardwareOptionTypeNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ImageURLDetailJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ImageURLDetailNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.InputAudioFormatJsonConverter),

            typeof(global::DeepInfra.JsonConverters.InputAudioFormatNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ModelDocBlockKeyJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ModelDocBlockKeyNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ModelProviderJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ModelProviderNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIBatchesInEndpointJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIBatchesInEndpointNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIChatCompletionsInToolChoiceJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIChatCompletionsInToolChoiceNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIChatCompletionsInReasoningEffort2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIChatCompletionsInReasoningEffort2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInInputType2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInInputType2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInEncodingFormatJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIEmbeddingsInEncodingFormatNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIFilePurposeJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIFilePurposeNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIImagesResponseFormatJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenAIImagesResponseFormatNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.PresetConfigOutStandardArgsKvCacheDtype2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.PresetConfigOutStandardArgsKvCacheDtype2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.PresetConfigOutStandardArgsQuantization2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.PresetConfigOutStandardArgsQuantization2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.PricingTypeJsonConverter),

            typeof(global::DeepInfra.JsonConverters.PricingTypeNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.PromptCacheOptionsMode2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.PromptCacheOptionsMode2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.PromptCacheOptionsTtl2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.PromptCacheOptionsTtl2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.RebalanceStatusDirectionJsonConverter),

            typeof(global::DeepInfra.JsonConverters.RebalanceStatusDirectionNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.SchemaVariantKeyJsonConverter),

            typeof(global::DeepInfra.JsonConverters.SchemaVariantKeyNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ServiceTierJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ServiceTierNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.SourceTypeEnumJsonConverter),

            typeof(global::DeepInfra.JsonConverters.SourceTypeEnumNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.StandardArgsKvCacheDtype2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.StandardArgsKvCacheDtype2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.StandardArgsQuantization2JsonConverter),

            typeof(global::DeepInfra.JsonConverters.StandardArgsQuantization2NullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.TtsResponseFormatJsonConverter),

            typeof(global::DeepInfra.JsonConverters.TtsResponseFormatNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ContainerRentalsListV1ContainersGetStateJsonConverter),

            typeof(global::DeepInfra.JsonConverters.ContainerRentalsListV1ContainersGetStateNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenclawListV1AgentsGetStateJsonConverter),

            typeof(global::DeepInfra.JsonConverters.OpenclawListV1AgentsGetStateNullableJsonConverter),

            typeof(global::DeepInfra.JsonConverters.InputVariant2ItemVariant2ItemJsonConverter),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo>>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.HardwarePricingServerless, global::DeepInfra.HardwarePricingDedicated>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength, global::DeepInfra.ModelPricingFrameUnits>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength, global::DeepInfra.ModelPricingFrameUnits>),

            typeof(global::DeepInfra.JsonConverters.OneOfJsonConverter<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.OpenAIChatCompletionsInToolChoice?, global::DeepInfra.FunctionTool, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>),

            typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength, global::DeepInfra.ModelPricingFrameUnits>),

            typeof(global::DeepInfra.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AddFundsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AddFundsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BillingAddressOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BillingPortalOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.Checklist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PaymentMethodOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SuspendReason), TypeInfoPropertyName = "SuspendReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ConfigIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ConfigOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeepStartApplicationIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeepStartApplicationOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DiscountMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InvoiceListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InvoicesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.InvoiceListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PaymentMethodBank))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PaymentMethodCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PaymentMethodCashApp))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AgentBackupOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::DeepInfra.AgentTypeMetaOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AgentTypeMetaOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AgentCreateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AgentCreateOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AgentInstanceOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AgentInstanceState), TypeInfoPropertyName = "AgentInstanceState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AgentPlanOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AgentPlanOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AgentUpdateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicMessagesIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ServiceTier), TypeInfoPropertyName = "ServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>), TypeInfoPropertyName = "AnyOfStringIListAnthropicSystemContentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicSystemContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicThinkingConfigType2), TypeInfoPropertyName = "AnthropicThinkingConfigType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicTokenCountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ApiToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ApiTokenIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ApiTokenVercelExportIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BatchErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BatchErrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.BatchErrorData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BatchInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BatchOutputExpiresAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BatchOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BatchRequestCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BatchUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyCreateVoiceV1VoicesAddPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat2), TypeInfoPropertyName = "BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item), TypeInfoPropertyName = "BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat2), TypeInfoPropertyName = "BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiFilesV1FilesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiImagesEditsV1ImagesEditsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesEditsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesResponseFormat), TypeInfoPropertyName = "OpenAIImagesResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyOpenaiImagesVariationsV1ImagesVariationsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesVariationsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BodyUpdateVoiceV1VoicesVoiceIdEditPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>), TypeInfoPropertyName = "AnyOfStringIListChatCompletionContentPartTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheBreakpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.VideoURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>), TypeInfoPropertyName = "AnyOfStringIListChatCompletionContentPartText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo>>>), TypeInfoPropertyName = "ChatCompletionContentPartVideo_ba71f0f0ed6c3c8a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo>>), TypeInfoPropertyName = "ChatCompletionContentPartVideo_42446b6a8b5bc71f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo>), TypeInfoPropertyName = "ChatCompletionContentPartVideo_564b9ad0201a3c82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatReasoningSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatReasoningSettingsEffort2), TypeInfoPropertyName = "ChatReasoningSettingsEffort22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.CompletionMultiModalData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalStateOut), TypeInfoPropertyName = "ContainerRentalStateOut2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalStartIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalStartOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalUpdateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.CreateLoraApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SourceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeepError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployArgsHistoryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployGPUAvailability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.GPUAvailabilityInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.GPUAvailabilityInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployGPUs), TypeInfoPropertyName = "DeployGPUs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployInstances))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployLLMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HFWeights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployLLMIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ScaleSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.StandardArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployLLMUpdateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployModelIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelProvider), TypeInfoPropertyName = "ModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployRollout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployStatusOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeployType), TypeInfoPropertyName = "DeployType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentLogQueryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentMainStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentOutStandardArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentOutStandardArgsKvCacheDtype2), TypeInfoPropertyName = "DeploymentOutStandardArgsKvCacheDtype22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentOutStandardArgsQuantization2), TypeInfoPropertyName = "DeploymentOutStandardArgsQuantization22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DetailedDeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.LLMDeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.EmbeddingsDeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TimeDeploymentStatsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DetokenizeIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DetokenizeOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.DisplayNameIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ElevenLabsTextToSpeechIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TtsResponseFormat), TypeInfoPropertyName = "TtsResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.EmailsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FAQEntryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FeedbackIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.GetVoicesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.GpuPoolOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.GpuPoolRequestIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.GpuTypesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.DeployGPUs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HFModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HFTasksE), TypeInfoPropertyName = "HFTasksE2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwareOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwareOptionType), TypeInfoPropertyName = "HardwareOptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.HardwarePricingServerless, global::DeepInfra.HardwarePricingDedicated>), TypeInfoPropertyName = "AnyOfHardwarePricingServerlessHardwarePricingDedicated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwarePricingServerless))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwarePricingDedicated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HardwareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.HardwareOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ImageURLDetail), TypeInfoPropertyName = "ImageURLDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputAudioFormat), TypeInfoPropertyName = "InputAudioFormat2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelDocBlockKey), TypeInfoPropertyName = "ModelDocBlockKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelFamilyOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.PricingPageSectionOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PricingPageSectionOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.FAQEntryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelFieldInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelInfoOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ModelFieldInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength, global::DeepInfra.ModelPricingFrameUnits>), TypeInfoPropertyName = "ModelPricingFrameUnits_74364e10aab2ab1b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingUptime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingInputLength))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingInputTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingInputCharacterLength))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingImageUnits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingOutputLength))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPricingFrameUnits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ModelDocBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.SchemaVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SchemaVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelMetaIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelNameSuggestionOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength, global::DeepInfra.ModelPricingFrameUnits>), TypeInfoPropertyName = "ModelPricingFrameUnits_b60964b5ebc3097b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ModelPublicityIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIBatchesIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIBatchesInEndpoint), TypeInfoPropertyName = "OpenAIBatchesInEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIBatchesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIChatCompletionsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.OneOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OneOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>), TypeInfoPropertyName = "OneOfChatCompletionToolMessageChatCompletionAssistantMessageChatCompletionUserMessageChatCompletionSystemMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.FunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.OpenAIChatCompletionsInToolChoice?, global::DeepInfra.FunctionTool, object>), TypeInfoPropertyName = "AnyOfOpenAIChatCompletionsInToolChoiceFunctionToolObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIChatCompletionsInToolChoice), TypeInfoPropertyName = "OpenAIChatCompletionsInToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>), TypeInfoPropertyName = "AnyOfTextResponseFormatJsonObjectResponseFormatJsonSchemaResponseFormatRegexResponseFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TextResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RegexResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.StreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIChatCompletionsInReasoningEffort2), TypeInfoPropertyName = "OpenAIChatCompletionsInReasoningEffort22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAICompletionsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>), TypeInfoPropertyName = "AnyOfStringIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfStringIListInputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>), TypeInfoPropertyName = "AnyOfStringIListInputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputVariant2ItemVariant2Item), TypeInfoPropertyName = "InputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType), TypeInfoPropertyName = "OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInInputType2), TypeInfoPropertyName = "OpenAIEmbeddingsInInputType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInEncodingFormat), TypeInfoPropertyName = "OpenAIEmbeddingsInEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIFilePurpose), TypeInfoPropertyName = "OpenAIFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesGenerationsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIImagesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.OpenAIImageData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIModelsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.OpenAIModelOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAITextToSpeechIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenClawLaunchTokenOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenRouterModelsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PresetConfigOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PresetConfigOutStandardArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PresetConfigOutStandardArgsKvCacheDtype2), TypeInfoPropertyName = "PresetConfigOutStandardArgsKvCacheDtype22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PresetConfigOutStandardArgsQuantization2), TypeInfoPropertyName = "PresetConfigOutStandardArgsQuantization22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PricingPageEntryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PricingType), TypeInfoPropertyName = "PricingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.PricingPageEntryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsMode2), TypeInfoPropertyName = "PromptCacheOptionsMode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsTtl2), TypeInfoPropertyName = "PromptCacheOptionsTtl22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RateLimitOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RateLimitRequestIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RebalanceCancelIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RebalanceCancelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RebalanceIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RebalanceOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RebalanceStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RebalanceStatusDirection), TypeInfoPropertyName = "RebalanceStatusDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RebalanceStatusOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.RebalanceStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RequestCostItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RequestCostQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RequestCostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.RequestCostItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SandboxCreateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SandboxCreateOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SandboxExecIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SandboxOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SandboxPlanOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SchemaOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SchemaVariantKey), TypeInfoPropertyName = "SchemaVariantKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ScopedJWTIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ScopedJWTOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SourceTypeEnum), TypeInfoPropertyName = "SourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SshKeyIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SshKeyOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.StandardArgsKvCacheDtype2), TypeInfoPropertyName = "StandardArgsKvCacheDtype22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.StandardArgsQuantization2), TypeInfoPropertyName = "StandardArgsQuantization22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TokenizeIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TokenizeOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.UpdateLoraApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.VideoGenerationIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.VideoGenerationOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.WebLiveMetricsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.WebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ContainerRentalsListV1ContainersGetState), TypeInfoPropertyName = "ContainerRentalsListV1ContainersGetState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenclawListV1AgentsGetState), TypeInfoPropertyName = "OpenclawListV1AgentsGetState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.PresetConfigOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.DeploymentOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.DeploymentMainStatsOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.DeployArgsHistoryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ModelOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ContainerRentalOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ApiToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.SshKeyOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AgentInstanceOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AgentBackupOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.SandboxOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.SandboxPlanOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo>>>?), TypeInfoPropertyName = "ChatCompletionContentPartVideo_da2c47f6e81dd0c4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo>?), TypeInfoPropertyName = "ChatCompletionContentPartVideo_06f031293c314952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength, global::DeepInfra.ModelPricingFrameUnits>?), TypeInfoPropertyName = "ModelPricingFrameUnits_6ea86b27c5e04f0a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ModelPricingTime, global::DeepInfra.ModelPricingTokens, global::DeepInfra.ModelPricingInputLength, global::DeepInfra.ModelPricingInputTokens, global::DeepInfra.ModelPricingUptime, global::DeepInfra.ModelPricingInputCharacterLength, global::DeepInfra.ModelPricingImageUnits, global::DeepInfra.ModelPricingOutputLength, global::DeepInfra.ModelPricingFrameUnits>?), TypeInfoPropertyName = "ModelPricingFrameUnits_ed89053ab1900c9d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.InvoiceListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.UsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.UsageMonth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AgentPlanOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnthropicSystemContent>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnthropicSystemContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnthropicTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.BatchErrorData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo>>>), TypeInfoPropertyName = "ChatCompletionContentPartVideo_fbe3cba047b686e0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo>>), TypeInfoPropertyName = "ChatCompletionContentPartVideo_0799573126f8224b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.GPUAvailabilityInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.DeployGPUs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.HardwareOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.PricingPageSectionOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.FAQEntryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ModelFieldInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ModelDocBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.SchemaVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.OneOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.FunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.OpenAIImageData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.OpenAIModelOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.PricingPageEntryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.RebalanceStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.RequestCostItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.PresetConfigOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.DeploymentOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.DeploymentMainStatsOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.DeployArgsHistoryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ModelOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ContainerRentalOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ApiToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.SshKeyOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AgentInstanceOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AgentBackupOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.SandboxOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.SandboxPlanOut>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}