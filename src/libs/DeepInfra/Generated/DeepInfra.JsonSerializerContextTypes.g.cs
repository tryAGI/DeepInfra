
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AddCardOut? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AddFundsIn? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AddFundsOut? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BillingAddressOut? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BillingPortalOut? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Checklist? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodOut? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SuspendReason? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ScopedCredit>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScopedCredit? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.NewCustomerLimits? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ConfigIn? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ConfigOut? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepError? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepStartApplicationIn? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepStartApplicationOut? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InceptionMemberCheck? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DiscountMeta? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HTTPValidationError? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ValidationError>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ValidationError? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InceptionMemberCheckStatus? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InvoiceListItem? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InvoicesOut? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.InvoiceListItem>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.KeyLimitIn? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.KeyLimitOut? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelMeta? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodBank? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodCard? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodCashApp? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TimeInterval? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TopUpIn? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageItem? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageMonth? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.UsageItem>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageOut? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.UsageMonth>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageRentOut? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, int?>>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, int?>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentBackupOut? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::DeepInfra.AgentTypeMetaOut>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentTypeMetaOut? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentCreateIn? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentCreateOut? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentInstanceOut? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentInstanceState? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentPlanOut? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentPlanOut>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentUpdateIn? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicMessagesIn? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ServiceTier? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicSystemContent? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicTool? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicThinkingConfig? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicOutputConfig? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicModelOut? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicModelsOut? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnthropicModelOut>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicOutputConfigEffort? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicThinkingConfigType? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicTokenCountRequest? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiToken? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.Scope>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Scope? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenIn? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenScopeOut? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenScopesIn? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenVercelExportBodyIn? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AudioURL? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchErrorData? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchErrors? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.BatchErrorData>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchInputTokensDetails? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchOutputExpiresAfter? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchOutputTokensDetails? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchRequestCounts? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchUsage? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyCreateVoiceV1VoicesAddPost? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPost? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPost? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiFilesV1FilesPost? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiImagesEditsV1ImagesEditsPost? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesEditsIn? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesResponseFormat? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiImagesVariationsV1ImagesVariationsPost? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesVariationsIn? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyUpdateVoiceV1VoicesVoiceIdEditPost? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionAssistantMessage? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartText? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionMessageToolCall>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionMessageToolCall? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartAudio? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputAudio? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartAudioURL? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartFile? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FileData? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartImage? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ImageURL? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheBreakpoint? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartVideo? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoURL? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Function? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionSystemMessage? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionToolMessage? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionUserMessage? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatReasoningSettings? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatReasoningSettingsEffort? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChoiceAnswer? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CompletionMultiModalData? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalOut? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStateOut? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStartIn? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStartOut? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalUpdateIn? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CreateLoraApiRequest? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SourceModel? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CreatedApiToken? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CustomerRateLimitRequestOut? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RateLimitRequestState? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CustomerRateLimitRequestsOut? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.CustomerRateLimitRequestOut>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployArgsHistoryOut? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployDelete? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployGPUAvailability? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.GPUAvailabilityInfo>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GPUAvailabilityInfo? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployGPUs? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployInstances? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMConfig? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFWeights? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMIn? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScaleSettings? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgs? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMUpdateIn? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployModelIn? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelProvider? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployResult? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployRollout? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployStatusOut? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentLogQueryOut? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentMainStatsOut? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOut? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgs? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgsKvCacheDtype? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgsQuantization? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentStatsOut? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetailedDeploymentStatsOut? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LLMDeploymentStatsOut? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.EmbeddingsDeploymentStatsOut? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TimeDeploymentStatsOut? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetokenizeIn? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetokenizeOut? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DisplayNameIn? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ElevenLabsTextToSpeechIn? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TtsResponseFormat? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.EmailsOut? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FAQEntryOut? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FeedbackIn? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FunctionDefinition? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FunctionTool? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GetVoicesOut? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.Voice>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Voice? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolOut? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolPendingRequestOut? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolRejectionOut? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolRequestIn? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuTypesOut? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeployGPUs>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFModel? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFTasksE? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareOption? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareOptionType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.HardwarePricingServerless, global::DeepInfra.HardwarePricingDedicated>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwarePricingServerless? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwarePricingDedicated? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareResponse? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.HardwareOption>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ImageURLDetail? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputAudioFormat? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputFilePart? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputFunctionCallItem? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputFunctionCallOutputItem? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart>>>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart>>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputTextPart? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputImagePart? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputImagePartDetail? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputMessageItem? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputMessageItemRole? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OutputTextPart? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputReasoningItem? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ReasoningSummaryPart>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ReasoningSummaryPart? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InspectScopedJWTOut? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonObjectResponseFormat? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonSchema? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonSchemaResponseFormat? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ListModelsResponse? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeepinfraDeepapiSystemoneWireModelMetadata>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepinfraDeepapiSystemoneWireModelMetadata? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LogQueryOut? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Me? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.MeVercelConnection? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.MeIn? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.MediaIoKwargs? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoDecodeOptions? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelDocBlock? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelDocBlockKey? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelFamilyOut? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PricingPageSectionOut>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingPageSectionOut? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.FAQEntryOut>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelFieldInfo? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelInfoOut? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelFieldInfo>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingTime? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingUptime? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingTokens? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputLength? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputTokens? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputCharacterLength? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingImageUnits? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingOutputLength? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingFrameUnits? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelDocBlock>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SchemaVariant>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaVariant? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelMetaIn? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelNameSuggestionOut? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelOut? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPublicityIn? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.NoulAnswer? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesIn? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesInEndpoint? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesOut? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsIn? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OneOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.FunctionTool>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.OpenAIChatCompletionsInToolChoice?, global::DeepInfra.FunctionTool>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsInToolChoice? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TextResponseFormat? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RegexResponseFormat? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StreamOptions? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsInReasoningEffort? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptions? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAICompletionsIn? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsIn? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputVariant2ItemVariant2Item? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminator? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInTask? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIFile? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIFilePurpose? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImageData? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesGenerationsIn? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesOut? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.OpenAIImageData>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIModelOut? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepinfraDeepapiModelsModelMetadata? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIModelsOut? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.OpenAIModelOut>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAITextToSpeechIn? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenClawLaunchTokenOut? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenRouterModelsOut? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOut? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgs? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgsKvCacheDtype? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgsQuantization? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingPageEntryOut? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingType? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PricingPageEntryOut>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptionsMode? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptionsTtl? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RateLimitOut? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RateLimitRequestIn? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ReasoningSummaryPartType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceCancelIn? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceCancelOut? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceIn? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceOut? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatus? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatusDirection? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatusOut? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.RebalanceStatus>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostItem? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostQuery? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostResponse? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.RequestCostItem>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesFunctionTool? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesFunctionToolChoice? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesIn? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesWebSearchTool? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesNamespaceTool? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesInToolChoiceEnum?, global::DeepInfra.ResponsesFunctionToolChoice, object>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesInToolChoiceEnum? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesTextConfig? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesReasoningConfig? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesInTruncation? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesReasoningConfigEffort? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesTextFormatText, global::DeepInfra.ResponsesTextFormatJsonObject, global::DeepInfra.ResponsesTextFormatJsonSchema>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesTextFormatText? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesTextFormatJsonObject? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesTextFormatJsonSchema? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxCreateIn? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxCreateOut? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxExecIn? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxOut? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxPlanOut? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaOut? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaVariantKey? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScopedJWTIn? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScopedJWTOut? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScoreAnswer? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SourceTypeEnum? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SshKeyIn? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SshKeyOut? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgsKvCacheDtype? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgsQuantization? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemOneResponse? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.NoulAnswer, global::DeepInfra.ChoiceAnswer, global::DeepInfra.ScoreAnswer>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Usage? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TokenizeIn? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TokenizeOut? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UpdateLoraApiRequest? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoGenerationIn? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoGenerationOut? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.WebLiveMetricsOut? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.WebSearchTool? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AllOf<global::DeepInfra.VideoGenerationIn, global::DeepInfra.CreateVideoGenerationV1VideosPostRequest2>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CreateVideoGenerationV1VideosPostRequest2? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AllOf<global::DeepInfra.VideoGenerationIn, global::DeepInfra.CreateVideoGenerationV1OpenaiVideosPostRequest2>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CreateVideoGenerationV1OpenaiVideosPostRequest2? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequest? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Questions? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestionCriteria? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminator? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalsListV1ContainersGetState? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenclawListV1AgentsGetState? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PresetConfigOut>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeploymentOut>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeploymentMainStatsOut>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeployArgsHistoryOut>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelOut>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ContainerRentalOut>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ApiToken>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ApiTokenScopeOut>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SshKeyOut>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentInstanceOut>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentBackupOut>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SandboxOut>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SandboxPlanOut>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.KeyLimitOut>? Type407 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ScopedCredit>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ValidationError>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.InvoiceListItem>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.UsageItem>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.UsageMonth>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, int?>>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AgentPlanOut>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnthropicSystemContent>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnthropicSystemContent>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnthropicTool>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnthropicModelOut>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.Scope>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.BatchErrorData>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionMessageToolCall>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.CustomerRateLimitRequestOut>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.GPUAvailabilityInfo>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.Voice>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeployGPUs>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.HardwareOption>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart>>>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart>>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ReasoningSummaryPart>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeepinfraDeepapiSystemoneWireModelMetadata>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PricingPageSectionOut>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.FAQEntryOut>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelFieldInfo>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelDocBlock>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SchemaVariant>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.FunctionTool>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<int>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.OpenAIImageData>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.OpenAIModelOut>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PricingPageEntryOut>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.RebalanceStatus>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.RequestCostItem>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.List<object>>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.List<object>>>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PresetConfigOut>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeploymentOut>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeploymentMainStatsOut>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeployArgsHistoryOut>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelOut>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ContainerRentalOut>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ApiToken>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ApiTokenScopeOut>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SshKeyOut>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AgentInstanceOut>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AgentBackupOut>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SandboxOut>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SandboxPlanOut>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.KeyLimitOut>? ListType70 { get; set; }
    }
}