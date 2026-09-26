
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ServiceTier), TypeInfoPropertyName = "ServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ChatCompletionContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PromptCacheBreakpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ImageURLDetail), TypeInfoPropertyName = "ImageURLDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfStringIListInputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>), TypeInfoPropertyName = "AnyOfStringIListInputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputVariant2ItemVariant2Item), TypeInfoPropertyName = "InputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType), TypeInfoPropertyName = "OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInInputType), TypeInfoPropertyName = "OpenAIEmbeddingsInInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInEncodingFormat), TypeInfoPropertyName = "OpenAIEmbeddingsInEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ServiceTier?), TypeInfoPropertyName = "NullableServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ImageURLDetail?), TypeInfoPropertyName = "NullableImageURLDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>>>?), TypeInfoPropertyName = "NullableAnyOfStringIListAnyOfStringIListInputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.InputVariant2ItemVariant2Item>>?), TypeInfoPropertyName = "NullableAnyOfStringIListInputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.InputVariant2ItemVariant2Item?), TypeInfoPropertyName = "NullableInputVariant2ItemVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType?), TypeInfoPropertyName = "NullableOpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInInputType?), TypeInfoPropertyName = "NullableOpenAIEmbeddingsInInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.OpenAIEmbeddingsInEncodingFormat?), TypeInfoPropertyName = "NullableOpenAIEmbeddingsInEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.InputVariant2ItemVariant2Item>))]
    internal sealed partial class EmbeddingsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbeddingsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EmbeddingsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.ChatCompletionContentPartText>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
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
                    typeToConvert == typeof(global::DeepInfra.ImageURLDetail)

                    || typeToConvert == typeof(global::DeepInfra.ImageURLDetail?)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInInputType)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInInputType?)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInEncodingFormat)

                    || typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInEncodingFormat?)

                    || typeToConvert == typeof(global::DeepInfra.ServiceTier)

                    || typeToConvert == typeof(global::DeepInfra.ServiceTier?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepInfra.ImageURLDetail))
                {
                    return new global::DeepInfra.JsonConverters.ImageURLDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.ImageURLDetail?))
                {
                    return new global::DeepInfra.JsonConverters.ImageURLDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorType?))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIEmbeddingsInInputVariant2ItemVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInInputType))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIEmbeddingsInInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInInputType?))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIEmbeddingsInInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInEncodingFormat))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIEmbeddingsInEncodingFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.OpenAIEmbeddingsInEncodingFormat?))
                {
                    return new global::DeepInfra.JsonConverters.OpenAIEmbeddingsInEncodingFormatNullableJsonConverter();
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
                    0 => new EmbeddingsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}