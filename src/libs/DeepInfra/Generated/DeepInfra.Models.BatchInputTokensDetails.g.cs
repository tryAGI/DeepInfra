
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchInputTokensDetails
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public int? ImageTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="imageTokens">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchInputTokensDetails(
            int? cachedTokens,
            int? imageTokens)
        {
            this.CachedTokens = cachedTokens;
            this.ImageTokens = imageTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputTokensDetails" /> class.
        /// </summary>
        public BatchInputTokensDetails()
        {
        }

    }
}