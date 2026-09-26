
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.CompletionMultiModalData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonObjectResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.JsonSchemaResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>), TypeInfoPropertyName = "AnyOfTextResponseFormatJsonObjectResponseFormatJsonSchemaResponseFormatRegexResponseFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.TextResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.RegexResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.StreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAICompletionsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>), TypeInfoPropertyName = "AnyOfStringIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsMode), TypeInfoPropertyName = "PromptCacheOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsTtl), TypeInfoPropertyName = "PromptCacheOptionsTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ServiceTier?), TypeInfoPropertyName = "NullableServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>?), TypeInfoPropertyName = "NullableAnyOfTextResponseFormatJsonObjectResponseFormatJsonSchemaResponseFormatRegexResponseFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<int>>?), TypeInfoPropertyName = "NullableAnyOfStringIListInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsMode?), TypeInfoPropertyName = "NullablePromptCacheOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheOptionsTtl?), TypeInfoPropertyName = "NullablePromptCacheOptionsTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<int>>))]
    internal sealed partial class TextCompletionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextCompletionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TextCompletionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TextCompletionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.TextResponseFormat, global::DeepInfra.JsonObjectResponseFormat, global::DeepInfra.JsonSchemaResponseFormat, global::DeepInfra.RegexResponseFormat, object>());
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
                    typeToConvert == typeof(global::DeepInfra.PromptCacheOptionsMode)

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
                    0 => new TextCompletionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}