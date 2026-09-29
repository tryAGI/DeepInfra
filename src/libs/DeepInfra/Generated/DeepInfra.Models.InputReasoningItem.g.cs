
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InputReasoningItem
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"reasoning"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "reasoning";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::System.Collections.Generic.IList<global::DeepInfra.ReasoningSummaryPart>? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::DeepInfra.ReasoningSummaryPart>? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputReasoningItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="summary"></param>
        /// <param name="content"></param>
        /// <param name="encryptedContent"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputReasoningItem(
            string? id,
            global::System.Collections.Generic.IList<global::DeepInfra.ReasoningSummaryPart>? summary,
            global::System.Collections.Generic.IList<global::DeepInfra.ReasoningSummaryPart>? content,
            string? encryptedContent,
            string? status,
            string type = "reasoning")
        {
            this.Type = type;
            this.Id = id;
            this.Summary = summary;
            this.Content = content;
            this.EncryptedContent = encryptedContent;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputReasoningItem" /> class.
        /// </summary>
        public InputReasoningItem()
        {
        }

    }
}