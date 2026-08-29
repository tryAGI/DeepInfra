
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelPricingTime
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
        /// Default Value: time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTime" /> class.
        /// </summary>
        /// <param name="centsPerSec"></param>
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
        /// Default Value: time
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingTime(
            double centsPerSec,
            double? discount,
            int? discountEndsAt,
            string? @short,
            string? full,
            object? table,
            string? type)
        {
            this.Discount = discount;
            this.DiscountEndsAt = discountEndsAt;
            this.Short = @short;
            this.Full = full;
            this.Table = table;
            this.Type = type;
            this.CentsPerSec = centsPerSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingTime" /> class.
        /// </summary>
        public ModelPricingTime()
        {
        }

    }
}