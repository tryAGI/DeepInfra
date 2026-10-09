
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ServiceTier), TypeInfoPropertyName = "ServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputFilePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputFunctionCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputFunctionCallOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputImagePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputImagePartDetail), TypeInfoPropertyName = "InputImagePartDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputMessageItemRole), TypeInfoPropertyName = "InputMessageItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfInputTextPartInputImagePartInputFilePartOutputTextPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>), TypeInfoPropertyName = "AnyOfInputTextPartInputImagePartInputFilePartOutputTextPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputTextPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OutputTextPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ReasoningSummaryPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ReasoningSummaryPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsMode), TypeInfoPropertyName = "PromptCacheOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsTtl), TypeInfoPropertyName = "PromptCacheOptionsTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ReasoningSummaryPartType), TypeInfoPropertyName = "ReasoningSummaryPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesFunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesFunctionToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfInputMessageItemInputFunctionCallItemInputFunctionCallOutputItemInputReasoningItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>), TypeInfoPropertyName = "AnyOfInputMessageItemInputFunctionCallItemInputFunctionCallOutputItemInputReasoningItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>), TypeInfoPropertyName = "AnyOfResponsesFunctionToolResponsesWebSearchToolResponsesNamespaceToolObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesWebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesNamespaceTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ResponsesInToolChoiceEnum?, global::DeepInfra.ResponsesFunctionToolChoice, object>), TypeInfoPropertyName = "AnyOfResponsesInToolChoiceEnumResponsesFunctionToolChoiceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesInToolChoiceEnum), TypeInfoPropertyName = "ResponsesInToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesTextConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesReasoningConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesInTruncation), TypeInfoPropertyName = "ResponsesInTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>), TypeInfoPropertyName = "AnyOfResponsesFunctionToolObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesReasoningConfigEffort), TypeInfoPropertyName = "ResponsesReasoningConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ResponsesTextFormatText, global::DeepInfra.ResponsesTextFormatJsonObject, global::DeepInfra.ResponsesTextFormatJsonSchema>), TypeInfoPropertyName = "AnyOfResponsesTextFormatTextResponsesTextFormatJsonObjectResponsesTextFormatJsonSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesTextFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesTextFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesTextFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ServiceTier?), TypeInfoPropertyName = "NullableServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputImagePartDetail?), TypeInfoPropertyName = "NullableInputImagePartDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputMessageItemRole?), TypeInfoPropertyName = "NullableInputMessageItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>>?), TypeInfoPropertyName = "NullableAnyOfStringIListAnyOfInputTextPartInputImagePartInputFilePartOutputTextPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>?), TypeInfoPropertyName = "NullableAnyOfInputTextPartInputImagePartInputFilePartOutputTextPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsMode?), TypeInfoPropertyName = "NullablePromptCacheOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsTtl?), TypeInfoPropertyName = "NullablePromptCacheOptionsTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ReasoningSummaryPartType?), TypeInfoPropertyName = "NullableReasoningSummaryPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>?), TypeInfoPropertyName = "NullableAnyOfStringIListAnyOfInputMessageItemInputFunctionCallItemInputFunctionCallOutputItemInputReasoningItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>?), TypeInfoPropertyName = "NullableAnyOfInputMessageItemInputFunctionCallItemInputFunctionCallOutputItemInputReasoningItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>?), TypeInfoPropertyName = "NullableAnyOfResponsesFunctionToolResponsesWebSearchToolResponsesNamespaceToolObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ResponsesInToolChoiceEnum?, global::DeepInfra.ResponsesFunctionToolChoice, object>?), TypeInfoPropertyName = "NullableAnyOfResponsesInToolChoiceEnumResponsesFunctionToolChoiceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesInToolChoiceEnum?), TypeInfoPropertyName = "NullableResponsesInToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesInTruncation?), TypeInfoPropertyName = "NullableResponsesInTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>?), TypeInfoPropertyName = "NullableAnyOfResponsesFunctionToolObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ResponsesReasoningConfigEffort?), TypeInfoPropertyName = "NullableResponsesReasoningConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.ResponsesTextFormatText, global::DeepInfra.ResponsesTextFormatJsonObject, global::DeepInfra.ResponsesTextFormatJsonSchema>?), TypeInfoPropertyName = "NullableAnyOfResponsesTextFormatTextResponsesTextFormatJsonObjectResponsesTextFormatJsonSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ReasoningSummaryPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>>))]
    internal sealed partial class ResponsesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ResponsesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ResponsesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.InputMessageItem, global::DeepInfra.InputFunctionCallItem, global::DeepInfra.InputFunctionCallOutputItem, global::DeepInfra.InputReasoningItem>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ResponsesFunctionTool, global::DeepInfra.ResponsesWebSearchTool, global::DeepInfra.ResponsesNamespaceTool, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ResponsesInToolChoiceEnum?, global::DeepInfra.ResponsesFunctionToolChoice, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ResponsesFunctionTool, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ResponsesTextFormatText, global::DeepInfra.ResponsesTextFormatJsonObject, global::DeepInfra.ResponsesTextFormatJsonSchema>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
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
                    typeToConvert == typeof(global::DeepInfra.InputImagePartDetail)

                    || typeToConvert == typeof(global::DeepInfra.InputImagePartDetail?)

                    || typeToConvert == typeof(global::DeepInfra.InputMessageItemRole)

                    || typeToConvert == typeof(global::DeepInfra.InputMessageItemRole?)

                    || typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsMode)

                    || typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsMode?)

                    || typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsTtl)

                    || typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsTtl?)

                    || typeToConvert == typeof(global::DeepInfra.ReasoningSummaryPartType)

                    || typeToConvert == typeof(global::DeepInfra.ReasoningSummaryPartType?)

                    || typeToConvert == typeof(global::DeepInfra.ResponsesInToolChoiceEnum)

                    || typeToConvert == typeof(global::DeepInfra.ResponsesInToolChoiceEnum?)

                    || typeToConvert == typeof(global::DeepInfra.ResponsesInTruncation)

                    || typeToConvert == typeof(global::DeepInfra.ResponsesInTruncation?)

                    || typeToConvert == typeof(global::DeepInfra.ResponsesReasoningConfigEffort)

                    || typeToConvert == typeof(global::DeepInfra.ResponsesReasoningConfigEffort?)

                    || typeToConvert == typeof(global::DeepInfra.ServiceTier)

                    || typeToConvert == typeof(global::DeepInfra.ServiceTier?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepInfra.InputImagePartDetail))
                {
                    return new global::DeepInfra.JsonConverters.InputImagePartDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.InputImagePartDetail?))
                {
                    return new global::DeepInfra.JsonConverters.InputImagePartDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.InputMessageItemRole))
                {
                    return new global::DeepInfra.JsonConverters.InputMessageItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.InputMessageItemRole?))
                {
                    return new global::DeepInfra.JsonConverters.InputMessageItemRoleNullableJsonConverter();
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

                if (typeToConvert == typeof(global::DeepInfra.ReasoningSummaryPartType))
                {
                    return new global::DeepInfra.JsonConverters.ReasoningSummaryPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ReasoningSummaryPartType?))
                {
                    return new global::DeepInfra.JsonConverters.ReasoningSummaryPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ResponsesInToolChoiceEnum))
                {
                    return new global::DeepInfra.JsonConverters.ResponsesInToolChoiceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ResponsesInToolChoiceEnum?))
                {
                    return new global::DeepInfra.JsonConverters.ResponsesInToolChoiceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ResponsesInTruncation))
                {
                    return new global::DeepInfra.JsonConverters.ResponsesInTruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ResponsesInTruncation?))
                {
                    return new global::DeepInfra.JsonConverters.ResponsesInTruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ResponsesReasoningConfigEffort))
                {
                    return new global::DeepInfra.JsonConverters.ResponsesReasoningConfigEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ResponsesReasoningConfigEffort?))
                {
                    return new global::DeepInfra.JsonConverters.ResponsesReasoningConfigEffortNullableJsonConverter();
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
                    0 => new ResponsesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}