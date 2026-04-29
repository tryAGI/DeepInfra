
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionMultiModalData
    {
        /// <summary>
        /// List of images as base64 data URIs (e.g. 'data:image/png;base64,...'). Each image must correspond to a placeholder token in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::System.Collections.Generic.IList<string>? Image { get; set; }

        /// <summary>
        /// List of videos as base64 data URIs (e.g. 'data:video/mp4;base64,...'). Each video must correspond to a placeholder token in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::System.Collections.Generic.IList<string>? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionMultiModalData" /> class.
        /// </summary>
        /// <param name="image">
        /// List of images as base64 data URIs (e.g. 'data:image/png;base64,...'). Each image must correspond to a placeholder token in the prompt.
        /// </param>
        /// <param name="video">
        /// List of videos as base64 data URIs (e.g. 'data:video/mp4;base64,...'). Each video must correspond to a placeholder token in the prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionMultiModalData(
            global::System.Collections.Generic.IList<string>? image,
            global::System.Collections.Generic.IList<string>? video)
        {
            this.Image = image;
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionMultiModalData" /> class.
        /// </summary>
        public CompletionMultiModalData()
        {
        }
    }
}