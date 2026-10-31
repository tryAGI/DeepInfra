
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoDecodeOptions
    {
        /// <summary>
        /// Number of frames sampled evenly across each input video. The engine default is 32.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_frames")]
        public int? NumFrames { get; set; }

        /// <summary>
        /// Scale every frame to exactly this width in pixels before the model sees it, so each frame costs the same input tokens whatever the source quality. Requires `height`; width x height is at most 1920x1080 pixels and the aspect ratio is not preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Frame height in pixels; see `width`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoDecodeOptions" /> class.
        /// </summary>
        /// <param name="numFrames">
        /// Number of frames sampled evenly across each input video. The engine default is 32.
        /// </param>
        /// <param name="width">
        /// Scale every frame to exactly this width in pixels before the model sees it, so each frame costs the same input tokens whatever the source quality. Requires `height`; width x height is at most 1920x1080 pixels and the aspect ratio is not preserved.
        /// </param>
        /// <param name="height">
        /// Frame height in pixels; see `width`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoDecodeOptions(
            int? numFrames,
            int? width,
            int? height)
        {
            this.NumFrames = numFrames;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoDecodeOptions" /> class.
        /// </summary>
        public VideoDecodeOptions()
        {
        }

    }
}