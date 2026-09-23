
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
        public object? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AddFundsOut? Type5 { get; set; }
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
        public global::DeepInfra.ConfigIn? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ConfigOut? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepStartApplicationIn? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepStartApplicationOut? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DiscountMeta? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HTTPValidationError? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ValidationError>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ValidationError? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InvoiceListItem? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InvoicesOut? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.InvoiceListItem>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelMeta? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodBank? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodCard? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodCashApp? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TimeInterval? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TopUpIn? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageItem? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageMonth? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.UsageItem>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageOut? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.UsageMonth>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageRentOut? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, int?>>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, int?>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentBackupOut? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::DeepInfra.AgentTypeMetaOut>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentTypeMetaOut? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentCreateIn? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentCreateOut? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentInstanceOut? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentInstanceState? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentPlanOut? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentPlanOut>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentUpdateIn? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicMessagesIn? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ServiceTier? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicSystemContent? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicTool? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicThinkingConfig? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicThinkingConfigType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicTokenCountRequest? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiToken? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenIn? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenVercelExportBodyIn? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenVercelExportIn? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchErrorData? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchErrors? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.BatchErrorData>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchInputTokensDetails? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchOutputExpiresAfter? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchOutputTokensDetails? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchRequestCounts? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchUsage? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyCreateVoiceV1VoicesAddPost? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPost? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPost? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiFilesV1FilesPost? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiImagesEditsV1ImagesEditsPost? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesEditsIn? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesResponseFormat? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiImagesVariationsV1ImagesVariationsPost? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesVariationsIn? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyUpdateVoiceV1VoicesVoiceIdEditPost? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionAssistantMessage? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartText? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionMessageToolCall>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionMessageToolCall? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartAudio? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputAudio? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartFile? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FileData? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartImage? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ImageURL? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheBreakpoint? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartVideo? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoURL? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Function? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionSystemMessage? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionToolMessage? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionUserMessage? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatReasoningSettings? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatReasoningSettingsEffort? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CompletionMultiModalData? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalOut? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStateOut? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStartIn? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStartOut? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalUpdateIn? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CreateLoraApiRequest? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SourceModel? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepError? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployArgsHistoryOut? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployDelete? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployGPUAvailability? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.GPUAvailabilityInfo>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GPUAvailabilityInfo? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployGPUs? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployInstances? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMConfig? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFWeights? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMIn? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScaleSettings? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgs? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMUpdateIn? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployModelIn? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelProvider? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployResult? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployRollout? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployStatusOut? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployType? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentLogQueryOut? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentMainStatsOut? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOut? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgs? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgsKvCacheDtype? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgsQuantization? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentStatsOut? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetailedDeploymentStatsOut? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LLMDeploymentStatsOut? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.EmbeddingsDeploymentStatsOut? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TimeDeploymentStatsOut? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetokenizeIn? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetokenizeOut? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DisplayNameIn? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ElevenLabsTextToSpeechIn? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TtsResponseFormat? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.EmailsOut? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FAQEntryOut? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FeedbackIn? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FunctionDefinition? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FunctionTool? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GetVoicesOut? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.Voice>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Voice? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolOut? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolPendingRequestOut? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolRejectionOut? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolRequestIn? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuTypesOut? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeployGPUs>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFModel? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFTasksE? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareOption? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareOptionType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.HardwarePricingServerless, global::DeepInfra.HardwarePricingDedicated>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwarePricingServerless? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwarePricingDedicated? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.HardwareOption>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ImageURLDetail? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputAudioFormat? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InspectScopedJWTOut? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonObjectResponseFormat? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonSchema? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonSchemaResponseFormat? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LogQueryOut? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LoraModelUploadIn? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Me? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.MeVercelConnection? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.MeIn? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelDocBlock? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelDocBlockKey? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelFamilyOut? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PricingPageSectionOut>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingPageSectionOut? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.FAQEntryOut>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelFieldInfo? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelInfoOut? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelFieldInfo>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingTime? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingUptime? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingTokens? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputLength? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputTokens? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputCharacterLength? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingImageUnits? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingOutputLength? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingFrameUnits? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelDocBlock>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SchemaVariant>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaVariant? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelMetaIn? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelMetadata? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelNameSuggestionOut? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelOut? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPublicityIn? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesIn? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesInEndpoint? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesOut? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsIn? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OneOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.FunctionTool>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.OpenAIChatCompletionsInToolChoice?, global::DeepInfra.FunctionTool, object>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsInToolChoice? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TextResponseFormat? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RegexResponseFormat? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StreamOptions? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsInReasoningEffort? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptions? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAICompletionsIn? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsIn? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputVariant2ItemVariant2Item? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminator? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIFile? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIFilePurpose? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImageData? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesGenerationsIn? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesOut? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.OpenAIImageData>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIModelOut? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIModelsOut? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.OpenAIModelOut>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAITextToSpeechIn? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenClawLaunchTokenOut? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenRouterModelsOut? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOut? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgs? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgsKvCacheDtype? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgsQuantization? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingPageEntryOut? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingType? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PricingPageEntryOut>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptionsMode? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptionsTtl? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RateLimitOut? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RateLimitRequestIn? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceCancelIn? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceCancelOut? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceIn? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceOut? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatus? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatusDirection? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatusOut? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.RebalanceStatus>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostItem? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostQuery? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.RequestCostItem>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxCreateIn? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxCreateOut? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxExecIn? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxOut? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxPlanOut? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaOut? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaVariantKey? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScopedJWTIn? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScopedJWTOut? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SourceTypeEnum? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SshKeyIn? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SshKeyOut? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgsKvCacheDtype? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgsQuantization? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TokenizeIn? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TokenizeOut? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UpdateLoraApiRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoGenerationIn? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoGenerationOut? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.WebLiveMetricsOut? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.WebSearchTool? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalsListV1ContainersGetState? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenclawListV1AgentsGetState? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PresetConfigOut>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeploymentOut>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeploymentMainStatsOut>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeployArgsHistoryOut>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelOut>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ContainerRentalOut>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ApiToken>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SshKeyOut>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentInstanceOut>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentBackupOut>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SandboxOut>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SandboxPlanOut>? Type320 { get; set; }

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
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnthropicSystemContent>, object>? ListType9 { get; set; }
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
        public global::System.Collections.Generic.List<global::DeepInfra.BatchErrorData>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>, object>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionMessageToolCall>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.GPUAvailabilityInfo>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.Voice>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeployGPUs>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.HardwareOption>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PricingPageSectionOut>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.FAQEntryOut>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelFieldInfo>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelDocBlock>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SchemaVariant>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<string>, object>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.FunctionTool>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<int>>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.OpenAIImageData>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.OpenAIModelOut>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PricingPageEntryOut>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.RebalanceStatus>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.RequestCostItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PresetConfigOut>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeploymentOut>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeploymentMainStatsOut>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeployArgsHistoryOut>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelOut>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ContainerRentalOut>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ApiToken>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SshKeyOut>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AgentInstanceOut>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AgentBackupOut>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SandboxOut>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SandboxPlanOut>? ListType54 { get; set; }
    }
}