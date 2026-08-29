
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelPricingTokens
    {
        /// <summary>
        /// Promotional discount; you are charged price * (1 - discount)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) when the discount ends, null when it has no scheduled end
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_ends_at")]
        public int? DiscountEndsAt { get; set; }

        /// <summary>
        /// Short description of the pricing, ideal for cards and headers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short")]
        public string? Short { get; set; }

        /// <summary>
        /// Full description of the pricing, perfect for details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full")]
        public string? Full { get; set; }

        /// <summary>
        /// Could be used to generate pricing tables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public object? Table { get; set; }

        /// <summary>
        /// Default Value: tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_input_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerInputToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_output_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerOutputToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_input_token_cached")]
        public double? RatePerInputTokenCached { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_input_token_cache_write")]
        public double? RatePerInputTokenCacheWrite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_service_tier_priority")]
        public double? RatePerServiceTierPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_service_tier_flex")]
        public double? RatePerServiceTierFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_per_explicit_cache_write_token")]
        public global::System.Collections.Generic.Dictionary<string, double>? RatePerExplicitCacheWriteToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explicit_cache_granularity_tokens")]
        public int? ExplicitCacheGranularityTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTokens" /> class.
        /// </summary>
        /// <param name="centsPerInputToken"></param>
        /// <param name="centsPerOutputToken"></param>
        /// <param name="discount">
        /// Promotional discount; you are charged price * (1 - discount)
        /// </param>
        /// <param name="discountEndsAt">
        /// Unix timestamp (seconds) when the discount ends, null when it has no scheduled end
        /// </param>
        /// <param name="short">
        /// Short description of the pricing, ideal for cards and headers
        /// </param>
        /// <param name="full">
        /// Full description of the pricing, perfect for details
        /// </param>
        /// <param name="table">
        /// Could be used to generate pricing tables
        /// </param>
        /// <param name="type">
        /// Default Value: tokens
        /// </param>
        /// <param name="ratePerInputTokenCached"></param>
        /// <param name="ratePerInputTokenCacheWrite"></param>
        /// <param name="ratePerServiceTierPriority"></param>
        /// <param name="ratePerServiceTierFlex"></param>
        /// <param name="ratePerExplicitCacheWriteToken"></param>
        /// <param name="explicitCacheGranularityTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingTokens(
            double centsPerInputToken,
            double centsPerOutputToken,
            double? discount,
            int? discountEndsAt,
            string? @short,
            string? full,
            object? table,
            string? type,
            double? ratePerInputTokenCached,
            double? ratePerInputTokenCacheWrite,
            double? ratePerServiceTierPriority,
            double? ratePerServiceTierFlex,
            global::System.Collections.Generic.Dictionary<string, double>? ratePerExplicitCacheWriteToken,
            int? explicitCacheGranularityTokens)
        {
            this.Discount = discount;
            this.DiscountEndsAt = discountEndsAt;
            this.Short = @short;
            this.Full = full;
            this.Table = table;
            this.Type = type;
            this.CentsPerInputToken = centsPerInputToken;
            this.CentsPerOutputToken = centsPerOutputToken;
            this.RatePerInputTokenCached = ratePerInputTokenCached;
            this.RatePerInputTokenCacheWrite = ratePerInputTokenCacheWrite;
            this.RatePerServiceTierPriority = ratePerServiceTierPriority;
            this.RatePerServiceTierFlex = ratePerServiceTierFlex;
            this.RatePerExplicitCacheWriteToken = ratePerExplicitCacheWriteToken;
            this.ExplicitCacheGranularityTokens = explicitCacheGranularityTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTokens" /> class.
        /// </summary>
        public ModelPricingTokens()
        {
        }

    }
}