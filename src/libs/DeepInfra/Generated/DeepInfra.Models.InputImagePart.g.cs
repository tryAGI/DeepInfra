
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InputImagePart
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"input_image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "input_image";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.InputImagePartDetailJsonConverter))]
        public global::DeepInfra.InputImagePartDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImagePart" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="fileId"></param>
        /// <param name="detail">
        /// Default Value: auto
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputImagePart(
            string? imageUrl,
            string? fileId,
            global::DeepInfra.InputImagePartDetail? detail,
            string type = "input_image")
        {
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImagePart" /> class.
        /// </summary>
        public InputImagePart()
        {
        }

    }
}