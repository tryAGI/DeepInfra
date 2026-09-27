
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo, global::DeepInfra.ChatCompletionContentPartFile>>>), TypeInfoPropertyName = "ChatCompletionContentPartFile_cc0a998e0353f854")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo, global::DeepInfra.ChatCompletionContentPartFile>>), TypeInfoPropertyName = "ChatCompletionContentPartFile_134cdd0110b89a61")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo, global::DeepInfra.ChatCompletionContentPartFile>), TypeInfoPropertyName = "ChatCompletionContentPartFile_28c6de1785ed61b2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo, global::DeepInfra.ChatCompletionContentPartFile>>>?), TypeInfoPropertyName = "ChatCompletionContentPartFile_5ac12912a27a9066")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo, global::DeepInfra.ChatCompletionContentPartFile>?), TypeInfoPropertyName = "ChatCompletionContentPartFile_a6726946c8fa511e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo, global::DeepInfra.ChatCompletionContentPartFile>>>), TypeInfoPropertyName = "ChatCompletionContentPartFile_f260d11795099675")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo, global::DeepInfra.ChatCompletionContentPartFile>>), TypeInfoPropertyName = "ChatCompletionContentPartFile_bef330d1edd9e5e7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicThinkingConfigType), TypeInfoPropertyName = "AnthropicThinkingConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicTokenCountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>), TypeInfoPropertyName = "AnyOfStringIListChatCompletionContentPartTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FileData))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatReasoningSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatReasoningSettingsEffort), TypeInfoPropertyName = "ChatReasoningSettingsEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ImageURLDetail), TypeInfoPropertyName = "ImageURLDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputAudioFormat), TypeInfoPropertyName = "InputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonObjectResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSchemaResponseFormat))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIChatCompletionsInReasoningEffort), TypeInfoPropertyName = "OpenAIChatCompletionsInReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputVariant2ItemVariant2Item), TypeInfoPropertyName = "InputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsMode), TypeInfoPropertyName = "PromptCacheOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsTtl), TypeInfoPropertyName = "PromptCacheOptionsTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ServiceTier?), TypeInfoPropertyName = "NullableServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListAnthropicSystemContentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnthropicThinkingConfigType?), TypeInfoPropertyName = "NullableAnthropicThinkingConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListChatCompletionContentPartTextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>?), TypeInfoPropertyName = "NullableAnyOfStringIListChatCompletionContentPartText2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatReasoningSettingsEffort?), TypeInfoPropertyName = "NullableChatReasoningSettingsEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ImageURLDetail?), TypeInfoPropertyName = "NullableImageURLDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputAudioFormat?), TypeInfoPropertyName = "NullableInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OneOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>?), TypeInfoPropertyName = "ChatCompletionSystemMessage_ab9fbe9def0da897")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.OpenAIChatCompletionsInToolChoice?, global::DeepInfra.FunctionTool, object>?), TypeInfoPropertyName = "NullableAnyOfOpenAIChatCompletionsInToolChoiceFunctionToolObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIChatCompletionsInToolChoice?), TypeInfoPropertyName = "NullableOpenAIChatCompletionsInToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>?), TypeInfoPropertyName = "NullableAnyOfTextResponseFormatJsonObjectResponseFormatJsonSchemaResponseFormatRegexResponseFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIChatCompletionsInReasoningEffort?), TypeInfoPropertyName = "NullableOpenAIChatCompletionsInReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputVariant2ItemVariant2Item?), TypeInfoPropertyName = "NullableInputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsMode?), TypeInfoPropertyName = "NullablePromptCacheOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsTtl?), TypeInfoPropertyName = "NullablePromptCacheOptionsTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnthropicSystemContent>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnthropicSystemContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnthropicTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.ChatCompletionContentPartText>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.OneOf<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.FunctionTool>))]
    internal sealed partial class ChatCompletionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatCompletionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatCompletionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::DeepInfra.JsonConverters.InputVariant2ItemVariant2ItemJsonConverter());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo, global::DeepInfra.ChatCompletionContentPartFile>>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio, global::DeepInfra.ChatCompletionContentPartVideo, global::DeepInfra.ChatCompletionContentPartFile>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.OneOfJsonConverter<global::DeepInfra.ChatCompletionToolMessage, global::DeepInfra.ChatCompletionAssistantMessage, global::DeepInfra.ChatCompletionUserMessage, global::DeepInfra.ChatCompletionSystemMessage>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.OpenAIChatCompletionsInToolChoice?, global::DeepInfra.FunctionTool, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::DeepInfra.AnthropicThinkingConfigType)

                    || typeToConvert == typeof(global::DeepInfra.AnthropicThinkingConfigType?)

                    || typeToConvert == typeof(global::DeepInfra.ChatReasoningSettingsEffort)

                    || typeToConvert == typeof(global::DeepInfra.ChatReasoningSettingsEffort?)

                    || typeToConvert == typeof(global::DeepInfra.ImageURLDetail)

                    || typeToConvert == typeof(global::DeepInfra.ImageURLDetail?)

                    || typeToConvert == typeof(global::DeepInfra.InputAudioFormat)

                    || typeToConvert == typeof(global::DeepInfra.InputAudioFormat?)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIChatCompletionsInToolChoice)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIChatCompletionsInToolChoice?)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIChatCompletionsInReasoningEffort)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIChatCompletionsInReasoningEffort?)

                    || typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsMode)

                    || typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsMode?)

                    || typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsTtl)

                    || typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsTtl?)

                    || typeToConvert == typeof(global::DeepInfra.ServiceTier)

                    || typeToConvert == typeof(global::DeepInfra.ServiceTier?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepInfra.AnthropicThinkingConfigType))
                {
                    return new global::DeepInfra.JsonConverters.AnthropicThinkingConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.AnthropicThinkingConfigType?))
                {
                    return new global::DeepInfra.JsonConverters.AnthropicThinkingConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ChatReasoningSettingsEffort))
                {
                    return new global::DeepInfra.JsonConverters.ChatReasoningSettingsEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ChatReasoningSettingsEffort?))
                {
                    return new global::DeepInfra.JsonConverters.ChatReasoningSettingsEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ImageURLDetail))
                {
                    return new global::DeepInfra.JsonConverters.ImageURLDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ImageURLDetail?))
                {
                    return new global::DeepInfra.JsonConverters.ImageURLDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.InputAudioFormat))
                {
                    return new global::DeepInfra.JsonConverters.InputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.InputAudioFormat?))
                {
                    return new global::DeepInfra.JsonConverters.InputAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIChatCompletionsInToolChoice))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIChatCompletionsInToolChoiceJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIChatCompletionsInToolChoice?))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIChatCompletionsInToolChoiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIChatCompletionsInReasoningEffort))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIChatCompletionsInReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIChatCompletionsInReasoningEffort?))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIChatCompletionsInReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsMode))
                {
                    return new global::DeepInfra.JsonConverters.PromptCacheOptionsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsMode?))
                {
                    return new global::DeepInfra.JsonConverters.PromptCacheOptionsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsTtl))
                {
                    return new global::DeepInfra.JsonConverters.PromptCacheOptionsTtlJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsTtl?))
                {
                    return new global::DeepInfra.JsonConverters.PromptCacheOptionsTtlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ServiceTier))
                {
                    return new global::DeepInfra.JsonConverters.ServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ServiceTier?))
                {
                    return new global::DeepInfra.JsonConverters.ServiceTierNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ChatCompletionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}