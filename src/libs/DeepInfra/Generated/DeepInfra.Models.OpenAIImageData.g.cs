
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIImageData
    {
        /// <summary>
        /// The prompt used to generate this image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revised_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RevisedPrompt { get; set; }

        /// <summary>
        /// The base64-encoded image data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string B64Json { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImageData" /> class.
        /// </summary>
        /// <param name="revisedPrompt">
        /// The prompt used to generate this image
        /// </param>
        /// <param name="b64Json">
        /// The base64-encoded image data
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OpenAIImageData(
            string revisedPrompt,
            string b64Json)
        {
            this.RevisedPrompt = revisedPrompt ?? throw new global::System.ArgumentNullException(nameof(revisedPrompt));
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImageData" /> class.
        /// </summary>
        public OpenAIImageData()
        {
        }
    }
}