
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelFamilyOut
    {
        /// <summary>
        /// Model family name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Model family title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Model family description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FeaturedModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pp_sections_out")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.PricingPageSectionOut> PpSectionsOut { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFamilyOut" /> class.
        /// </summary>
        /// <param name="name">
        /// Model family name
        /// </param>
        /// <param name="title">
        /// Model family title
        /// </param>
        /// <param name="description">
        /// Model family description
        /// </param>
        /// <param name="featuredModels"></param>
        /// <param name="ppSectionsOut"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelFamilyOut(
            string name,
            string title,
            string description,
            global::System.Collections.Generic.IList<string> featuredModels,
            global::System.Collections.Generic.IList<global::DeepInfra.PricingPageSectionOut> ppSectionsOut)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.FeaturedModels = featuredModels ?? throw new global::System.ArgumentNullException(nameof(featuredModels));
            this.PpSectionsOut = ppSectionsOut ?? throw new global::System.ArgumentNullException(nameof(ppSectionsOut));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFamilyOut" /> class.
        /// </summary>
        public ModelFamilyOut()
        {
        }
    }
}