
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MediaIoKwargs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::DeepInfra.VideoDecodeOptions? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaIoKwargs" /> class.
        /// </summary>
        /// <param name="video"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaIoKwargs(
            global::DeepInfra.VideoDecodeOptions? video)
        {
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaIoKwargs" /> class.
        /// </summary>
        public MediaIoKwargs()
        {
        }

    }
}