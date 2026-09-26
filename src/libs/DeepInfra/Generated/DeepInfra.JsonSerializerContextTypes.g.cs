
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
        public global::DeepInfra.DeepError? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepStartApplicationIn? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepStartApplicationOut? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DiscountMeta? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HTTPValidationError? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ValidationError>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ValidationError? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InvoiceListItem? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InvoicesOut? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.InvoiceListItem>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.KeyLimitIn? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.KeyLimitOut? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelMeta? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodBank? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodCard? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PaymentMethodCashApp? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TimeInterval? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TopUpIn? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageItem? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageMonth? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.UsageItem>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageOut? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.UsageMonth>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UsageRentOut? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, int?>>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, int?>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentBackupOut? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::DeepInfra.AgentTypeMetaOut>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentTypeMetaOut? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentCreateIn? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentCreateOut? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentInstanceOut? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentInstanceState? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentPlanOut? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentPlanOut>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AgentUpdateIn? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicMessagesIn? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ServiceTier? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicSystemContent? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicTool? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicThinkingConfig? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicThinkingConfigType? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnthropicTokenCountRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiToken? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenIn? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenVercelExportBodyIn? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ApiTokenVercelExportIn? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchErrorData? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchErrors? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.BatchErrorData>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchInputTokensDetails? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchOutputExpiresAfter? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchOutputTokensDetails? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchRequestCounts? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchUsage? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyCreateVoiceV1VoicesAddPost? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPost? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPost? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiFilesV1FilesPost? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiImagesEditsV1ImagesEditsPost? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesEditsIn? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesResponseFormat? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiImagesVariationsV1ImagesVariationsPost? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesVariationsIn? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyUpdateVoiceV1VoicesVoiceIdEditPost? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionAssistantMessage? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartText? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionMessageToolCall>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionMessageToolCall? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartAudio? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputAudio? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartFile? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FileData? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartImage? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ImageURL? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheBreakpoint? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartVideo? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoURL? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Function? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionSystemMessage? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionToolMessage? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionUserMessage? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatReasoningSettings? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatReasoningSettingsEffort? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChoiceAnswer? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChoiceQuestion? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>, object>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CompletionMultiModalData? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalOut? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStateOut? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStartIn? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStartOut? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalUpdateIn? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CreateLoraApiRequest? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SourceModel? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployArgsHistoryOut? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployDelete? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployGPUAvailability? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.GPUAvailabilityInfo>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GPUAvailabilityInfo? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployGPUs? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployInstances? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMConfig? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFWeights? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMIn? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScaleSettings? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgs? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMUpdateIn? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployModelIn? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelProvider? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployResult? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployRollout? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployStatusOut? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentLogQueryOut? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentMainStatsOut? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOut? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgs? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgsKvCacheDtype? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgsQuantization? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentStatsOut? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetailedDeploymentStatsOut? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LLMDeploymentStatsOut? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.EmbeddingsDeploymentStatsOut? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TimeDeploymentStatsOut? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetokenizeIn? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetokenizeOut? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DisplayNameIn? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ElevenLabsTextToSpeechIn? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TtsResponseFormat? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.EmailsOut? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FAQEntryOut? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FeedbackIn? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FunctionDefinition? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FunctionTool? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GetVoicesOut? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.Voice>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Voice? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolOut? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolPendingRequestOut? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolRejectionOut? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolRequestIn? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuTypesOut? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeployGPUs>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFModel? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFTasksE? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareOption? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareOptionType? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.HardwarePricingServerless, global::DeepInfra.HardwarePricingDedicated>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwarePricingServerless? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwarePricingDedicated? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareResponse? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.HardwareOption>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ImageURLDetail? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputAudioFormat? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InspectScopedJWTOut? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonObjectResponseFormat? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonSchema? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonSchemaResponseFormat? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ListModelsResponse? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeepinfraDeepapiSystemoneWireModelMetadata>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepinfraDeepapiSystemoneWireModelMetadata? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LogQueryOut? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LoraModelUploadIn? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Me? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.MeVercelConnection? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.MeIn? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelDocBlock? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelDocBlockKey? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelFamilyOut? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PricingPageSectionOut>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingPageSectionOut? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.FAQEntryOut>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelFieldInfo? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelInfoOut? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelFieldInfo>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingTime? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingUptime? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingTokens? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputLength? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputTokens? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputCharacterLength? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingImageUnits? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingOutputLength? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingFrameUnits? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelDocBlock>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SchemaVariant>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaVariant? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelMetaIn? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelNameSuggestionOut? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelOut? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPublicityIn? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.NoulAnswer? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.NoulCriteria? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.NoulQuestion? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesIn? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesInEndpoint? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesOut? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsIn? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OneOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.FunctionTool>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.OpenAIChatCompletionsInToolChoice?, global::DeepInfra.FunctionTool, object>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsInToolChoice? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TextResponseFormat? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RegexResponseFormat? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StreamOptions? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsInReasoningEffort? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptions? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAICompletionsIn? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsIn? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputVariant2ItemVariant2Item? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminator? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIFile? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIFilePurpose? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImageData? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesGenerationsIn? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesOut? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.OpenAIImageData>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIModelOut? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepinfraDeepapiModelsModelMetadata? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIModelsOut? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.OpenAIModelOut>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAITextToSpeechIn? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenClawLaunchTokenOut? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenRouterModelsOut? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOut? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgs? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgsKvCacheDtype? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgsQuantization? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingPageEntryOut? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PricingPageEntryOut>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptionsMode? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptionsTtl? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RateLimitOut? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RateLimitRequestIn? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceCancelIn? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceCancelOut? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceIn? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceOut? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatus? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatusDirection? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatusOut? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.RebalanceStatus>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostItem? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostQuery? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostResponse? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.RequestCostItem>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxCreateIn? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxCreateOut? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxExecIn? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxOut? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxPlanOut? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaOut? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaVariantKey? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScopedJWTIn? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScopedJWTOut? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScoreAnswer? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScoreQuestion? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SourceTypeEnum? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SshKeyIn? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SshKeyOut? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgsKvCacheDtype? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgsQuantization? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemOneRequest? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Questions? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemOneRequestQuestionsDiscriminator? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemOneRequestQuestionsDiscriminatorType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemOneResponse? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.NoulAnswer, global::DeepInfra.ChoiceAnswer, global::DeepInfra.ScoreAnswer>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Usage? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TokenizeIn? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TokenizeOut? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UpdateLoraApiRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoGenerationIn? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoGenerationOut? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.WebLiveMetricsOut? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.WebSearchTool? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalsListV1ContainersGetState? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenclawListV1AgentsGetState? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PresetConfigOut>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeploymentOut>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeploymentMainStatsOut>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeployArgsHistoryOut>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelOut>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ContainerRentalOut>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ApiToken>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SshKeyOut>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentInstanceOut>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentBackupOut>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SandboxOut>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SandboxPlanOut>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.KeyLimitOut>? Type343 { get; set; }

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
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.List<object>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.List<object>, object>? ListType20 { get; set; }
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
        public global::System.Collections.Generic.List<global::DeepInfra.DeepinfraDeepapiSystemoneWireModelMetadata>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PricingPageSectionOut>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.FAQEntryOut>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelFieldInfo>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelDocBlock>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SchemaVariant>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<string>, object>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.FunctionTool>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<int>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.OpenAIImageData>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.OpenAIModelOut>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PricingPageEntryOut>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.RebalanceStatus>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.RequestCostItem>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.List<object>>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PresetConfigOut>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeploymentOut>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeploymentMainStatsOut>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeployArgsHistoryOut>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelOut>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ContainerRentalOut>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ApiToken>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SshKeyOut>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AgentInstanceOut>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AgentBackupOut>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SandboxOut>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SandboxPlanOut>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.KeyLimitOut>? ListType59 { get; set; }
    }
}