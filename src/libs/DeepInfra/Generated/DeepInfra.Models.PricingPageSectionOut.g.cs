
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricingPageSectionOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ptype")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.PricingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.PricingType Ptype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Model family description for this section, if applicable. Will use description from the section if not set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mf_description")]
        public string? MfDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.PricingPageEntryOut> Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPageSectionOut" /> class.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="ptype"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="mfDescription">
        /// Model family description for this section, if applicable. Will use description from the section if not set
        /// </param>
        /// <param name="entries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingPageSectionOut(
            string sectionId,
            global::DeepInfra.PricingType ptype,
            string title,
            string description,
            global::System.Collections.Generic.IList<global::DeepInfra.PricingPageEntryOut> entries,
            string? mfDescription)
        {
            this.SectionId = sectionId ?? throw new global::System.ArgumentNullException(nameof(sectionId));
            this.Ptype = ptype;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
            this.MfDescription = mfDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingPageSectionOut" /> class.
        /// </summary>
        public PricingPageSectionOut()
        {
        }
    }
}