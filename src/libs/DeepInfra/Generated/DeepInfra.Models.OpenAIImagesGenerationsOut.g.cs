
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIImagesGenerationsOut
    {
        /// <summary>
        /// Unix timestamp of when the images were created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// List of generated images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.OpenAIImageData> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesGenerationsOut" /> class.
        /// </summary>
        /// <param name="created">
        /// Unix timestamp of when the images were created
        /// </param>
        /// <param name="data">
        /// List of generated images
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OpenAIImagesGenerationsOut(
            global::System.Collections.Generic.IList<global::DeepInfra.OpenAIImageData> data,
            global::System.DateTimeOffset? created)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesGenerationsOut" /> class.
        /// </summary>
        public OpenAIImagesGenerationsOut()
        {
        }
    }
}