
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPricingImageUnits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cents_per_image_unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CentsPerImageUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DefaultWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DefaultHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_iterations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DefaultIterations { get; set; }

        /// <summary>
        /// Default Value: image_units
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingImageUnits" /> class.
        /// </summary>
        /// <param name="centsPerImageUnit"></param>
        /// <param name="defaultWidth"></param>
        /// <param name="defaultHeight"></param>
        /// <param name="defaultIterations"></param>
        /// <param name="type">
        /// Default Value: image_units
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelPricingImageUnits(
            double centsPerImageUnit,
            int defaultWidth,
            int defaultHeight,
            int defaultIterations,
            string? type)
        {
            this.CentsPerImageUnit = centsPerImageUnit;
            this.DefaultWidth = defaultWidth;
            this.DefaultHeight = defaultHeight;
            this.DefaultIterations = defaultIterations;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingImageUnits" /> class.
        /// </summary>
        public ModelPricingImageUnits()
        {
        }
    }
}