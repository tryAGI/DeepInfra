
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemaVariant
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.SchemaVariantKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.SchemaVariantKey Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaVariant" /> class.
        /// </summary>
        /// <param name="key">
        /// An enumeration.
        /// </param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SchemaVariant(
            global::DeepInfra.SchemaVariantKey key,
            string url)
        {
            this.Key = key;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaVariant" /> class.
        /// </summary>
        public SchemaVariant()
        {
        }
    }
}