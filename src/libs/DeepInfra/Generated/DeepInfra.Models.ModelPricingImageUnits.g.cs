
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingImageUnits
    {
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
        /// Default Value: image_units
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_image_unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double CentsPerImageUnit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int DefaultWidth { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int DefaultHeight { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_iterations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int DefaultIterations { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_price_cents")]
        public double? DefaultPriceCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_from_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool UsageFromCost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingImageUnits" /> class.
        /// </summary>
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
        /// Default Value: image_units
        /// </param>
        /// <param name="centsPerImageUnit"></param>
        /// <param name="defaultWidth"></param>
        /// <param name="defaultHeight"></param>
        /// <param name="defaultIterations"></param>
        /// <param name="defaultPriceCents"></param>
        /// <param name="usageFromCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingImageUnits(
            double centsPerImageUnit,
            int defaultWidth,
            int defaultHeight,
            int defaultIterations,
            bool usageFromCost,
            string? @short,
            string? full,
            object? table,
            string? type,
            double? defaultPriceCents)
        {
            this.CentsPerImageUnit = centsPerImageUnit;
            this.DefaultWidth = defaultWidth;
            this.DefaultHeight = defaultHeight;
            this.DefaultIterations = defaultIterations;
            this.UsageFromCost = usageFromCost;
            this.Short = @short;
            this.Full = full;
            this.Table = table;
            this.Type = type;
            this.DefaultPriceCents = defaultPriceCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingImageUnits" /> class.
        /// </summary>
        public ModelPricingImageUnits()
        {
        }
    }
}