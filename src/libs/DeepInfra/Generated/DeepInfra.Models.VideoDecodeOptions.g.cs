
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumFrames { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoDecodeOptions(
            int numFrames)
        {
            this.NumFrames = numFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoDecodeOptions" /> class.
        /// </summary>
        public VideoDecodeOptions()
        {
        }

    }
}