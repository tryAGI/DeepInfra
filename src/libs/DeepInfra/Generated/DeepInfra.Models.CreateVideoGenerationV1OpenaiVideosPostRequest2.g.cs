
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoGenerationV1OpenaiVideosPostRequest2
    {
        /// <summary>
        /// First-frame image file for image-to-video; an alternative to image_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_reference")]
        public byte[]? InputReference { get; set; }

        /// <summary>
        /// First-frame image file for image-to-video; an alternative to image_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_referencename")]
        public string? InputReferencename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoGenerationV1OpenaiVideosPostRequest2" /> class.
        /// </summary>
        /// <param name="inputReference">
        /// First-frame image file for image-to-video; an alternative to image_url.
        /// </param>
        /// <param name="inputReferencename">
        /// First-frame image file for image-to-video; an alternative to image_url.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoGenerationV1OpenaiVideosPostRequest2(
            byte[]? inputReference,
            string? inputReferencename)
        {
            this.InputReference = inputReference;
            this.InputReferencename = inputReferencename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoGenerationV1OpenaiVideosPostRequest2" /> class.
        /// </summary>
        public CreateVideoGenerationV1OpenaiVideosPostRequest2()
        {
        }

    }
}