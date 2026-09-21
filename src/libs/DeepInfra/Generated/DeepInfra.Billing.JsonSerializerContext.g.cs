
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AddCardOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AddFundsIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AddFundsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BillingAddressOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.BillingPortalOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.Checklist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.PaymentMethodOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SuspendReason), TypeInfoPropertyName = "SuspendReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepInfra.ScopedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.ScopedCredit))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.SuspendReason?), TypeInfoPropertyName = "NullableSuspendReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepInfra.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ScopedCredit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.InvoiceListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.UsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.UsageMonth>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepInfra.AnyOf<string, int?>>))]
    internal sealed partial class BillingSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BillingSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BillingSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>>());
            options.Converters.Add(new global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
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
                    typeToConvert == typeof(global::DeepInfra.SuspendReason)

                    || typeToConvert == typeof(global::DeepInfra.SuspendReason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepInfra.SuspendReason))
                {
                    return new global::DeepInfra.JsonConverters.SuspendReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepInfra.SuspendReason?))
                {
                    return new global::DeepInfra.JsonConverters.SuspendReasonNullableJsonConverter();
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
                    0 => new BillingSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}