
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIImageData
    {
        /// <summary>
        /// The base64-encoded image data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        public string? B64Json { get; set; }

        /// <summary>
        /// The prompt used to generate this image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revised_prompt")]
        public string? RevisedPrompt { get; set; }

        /// <summary>
        /// The URL of the generated image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImageData" /> class.
        /// </summary>
        /// <param name="b64Json">
        /// The base64-encoded image data
        /// </param>
        /// <param name="revisedPrompt">
        /// The prompt used to generate this image
        /// </param>
        /// <param name="url">
        /// The URL of the generated image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIImageData(
            string? b64Json,
            string? revisedPrompt,
            string? url)
        {
            this.B64Json = b64Json;
            this.RevisedPrompt = revisedPrompt;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImageData" /> class.
        /// </summary>
        public OpenAIImageData()
        {
        }
    }
}