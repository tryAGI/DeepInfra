
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
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>>? Type59 { get; set; }
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
        public global::DeepInfra.AudioURL? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchErrorData? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchErrors? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.BatchErrorData>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchInputTokensDetails? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchOutputExpiresAfter? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchOutputTokensDetails? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchRequestCounts? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BatchUsage? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyCreateVoiceV1VoicesAddPost? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPost? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostResponseFormat? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranscriptionsV1AudioTranscriptionsPostTimestampGranularitiesVariant1Item? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPost? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiAudioTranslationsV1AudioTranslationsPostResponseFormat? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiFilesV1FilesPost? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiImagesEditsV1ImagesEditsPost? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesEditsIn? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesResponseFormat? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyOpenaiImagesVariationsV1ImagesVariationsPost? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesVariationsIn? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.BodyUpdateVoiceV1VoicesVoiceIdEditPost? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionAssistantMessage? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartText? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionMessageToolCall>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionMessageToolCall? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartAudio? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputAudio? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartAudioURL? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartFile? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FileData? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartImage? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ImageURL? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheBreakpoint? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionContentPartVideo? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoURL? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Function? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionSystemMessage? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionToolMessage? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatCompletionUserMessage? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatReasoningSettings? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChatReasoningSettingsEffort? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ChoiceAnswer? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CompletionMultiModalData? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalOut? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStateOut? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStartIn? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalStartOut? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalUpdateIn? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CreateLoraApiRequest? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SourceModel? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.CreatedApiToken? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployArgsHistoryOut? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployDelete? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployGPUAvailability? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.GPUAvailabilityInfo>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GPUAvailabilityInfo? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployGPUs? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployInstances? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMConfig? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFWeights? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMIn? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScaleSettings? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgs? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployLLMUpdateIn? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployModelIn? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelProvider? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployResult? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployRollout? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployStatusOut? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeployType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentLogQueryOut? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentMainStatsOut? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOut? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgs? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgsKvCacheDtype? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentOutStandardArgsQuantization? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeploymentStatsOut? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetailedDeploymentStatsOut? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LLMDeploymentStatsOut? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.EmbeddingsDeploymentStatsOut? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TimeDeploymentStatsOut? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetokenizeIn? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DetokenizeOut? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DisplayNameIn? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ElevenLabsTextToSpeechIn? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TtsResponseFormat? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.EmailsOut? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FAQEntryOut? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FeedbackIn? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FunctionDefinition? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.FunctionTool? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GetVoicesOut? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.Voice>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Voice? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolOut? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolPendingRequestOut? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolRejectionOut? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuPoolRequestIn? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.GpuTypesOut? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeployGPUs>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFModel? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HFTasksE? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareOption? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareOptionType? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.HardwarePricingServerless, global::DeepInfra.HardwarePricingDedicated>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwarePricingServerless? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwarePricingDedicated? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.HardwareResponse? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.HardwareOption>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ImageURLDetail? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputAudioFormat? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputFilePart? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputFunctionCallItem? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputFunctionCallOutputItem? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputImagePart? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputImagePartDetail? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputMessageItem? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputMessageItemRole? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputTextPart? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OutputTextPart? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputReasoningItem? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ReasoningSummaryPart>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ReasoningSummaryPart? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InspectScopedJWTOut? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonObjectResponseFormat? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonSchema? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.JsonSchemaResponseFormat? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ListModelsResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeepinfraDeepapiSystemoneWireModelMetadata>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepinfraDeepapiSystemoneWireModelMetadata? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LogQueryOut? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.LoraModelUploadIn? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Me? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.MeVercelConnection? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.MeIn? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelDocBlock? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelDocBlockKey? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelFamilyOut? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PricingPageSectionOut>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingPageSectionOut? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.FAQEntryOut>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelFieldInfo? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelInfoOut? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelFieldInfo>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingTime? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingUptime? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingTokens? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputLength? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputTokens? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingInputCharacterLength? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingImageUnits? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingOutputLength? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPricingFrameUnits? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelDocBlock>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SchemaVariant>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaVariant? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelMetaIn? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelNameSuggestionOut? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelOut? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ModelPublicityIn? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.NoulAnswer? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesIn? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesInEndpoint? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIBatchesOut? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsIn? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OneOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.FunctionTool>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.OpenAIChatCompletionsInToolChoice?, global::DeepInfra.FunctionTool>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsInToolChoice? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TextResponseFormat? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RegexResponseFormat? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StreamOptions? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIChatCompletionsInReasoningEffort? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptions? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAICompletionsIn? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsIn? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.InputVariant2ItemVariant2Item? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminator? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInInputType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInTask? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIEmbeddingsInEncodingFormat? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIFile? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIFilePurpose? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImageData? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesGenerationsIn? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIImagesOut? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.OpenAIImageData>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIModelOut? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.DeepinfraDeepapiModelsModelMetadata? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAIModelsOut? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.OpenAIModelOut>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenAITextToSpeechIn? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenClawLaunchTokenOut? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenRouterModelsOut? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOut? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgs? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgsKvCacheDtype? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PresetConfigOutStandardArgsQuantization? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingPageEntryOut? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PricingType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PricingPageEntryOut>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptionsMode? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.PromptCacheOptionsTtl? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RateLimitOut? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RateLimitRequestIn? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ReasoningSummaryPartType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceCancelIn? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceCancelOut? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceIn? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceOut? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatus? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatusDirection? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RebalanceStatusOut? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.RebalanceStatus>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostItem? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostQuery? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.RequestCostResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.RequestCostItem>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesFunctionTool? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesFunctionToolChoice? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesIn? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesWebSearchTool? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesNamespaceTool? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesInToolChoiceEnum?, global::DeepInfra.ResponsesFunctionToolChoice, object>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesInToolChoiceEnum? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesTextConfig? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesReasoningConfig? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesInTruncation? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesReasoningConfigEffort? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesTextFormatText, global::DeepInfra.ResponsesTextFormatJsonObject, global::DeepInfra.ResponsesTextFormatJsonSchema>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesTextFormatText? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesTextFormatJsonObject? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ResponsesTextFormatJsonSchema? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxCreateIn? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxCreateOut? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxExecIn? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxOut? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SandboxPlanOut? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaOut? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SchemaVariantKey? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScopedJWTIn? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScopedJWTOut? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ScoreAnswer? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SourceTypeEnum? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SshKeyIn? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SshKeyOut? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgsKvCacheDtype? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.StandardArgsQuantization? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemOneResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<global::DeepInfra.NoulAnswer, global::DeepInfra.ChoiceAnswer, global::DeepInfra.ScoreAnswer>? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Usage? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TokenizeIn? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.TokenizeOut? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.UpdateLoraApiRequest? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoGenerationIn? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.VideoGenerationOut? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.WebLiveMetricsOut? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.WebSearchTool? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequest? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.Questions? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestion? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsNoulQuestionCriteria? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsChoiceQuestion? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsScoreQuestion? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>>>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminator? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.SystemoneV1DecisionsPostRequestQuestionsDiscriminatorType? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.ContainerRentalsListV1ContainersGetState? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.OpenclawListV1AgentsGetState? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.PresetConfigOut>? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeploymentOut>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeploymentMainStatsOut>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.DeployArgsHistoryOut>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ModelOut>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ContainerRentalOut>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.ApiToken>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SshKeyOut>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentInstanceOut>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.AgentBackupOut>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SandboxOut>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.SandboxPlanOut>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::DeepInfra.KeyLimitOut>? Type383 { get; set; }

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
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>>? ListType15 { get; set; }
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
        public global::System.Collections.Generic.List<global::DeepInfra.GPUAvailabilityInfo>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.Voice>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeployGPUs>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.HardwareOption>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ReasoningSummaryPart>? ListType27 { get; set; }
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
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType34 { get; set; }
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
        public global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.List<object>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.List<object>>>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.PresetConfigOut>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeploymentOut>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeploymentMainStatsOut>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.DeployArgsHistoryOut>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ModelOut>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ContainerRentalOut>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.ApiToken>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SshKeyOut>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AgentInstanceOut>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.AgentBackupOut>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SandboxOut>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.SandboxPlanOut>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepInfra.KeyLimitOut>? ListType64 { get; set; }
    }
}