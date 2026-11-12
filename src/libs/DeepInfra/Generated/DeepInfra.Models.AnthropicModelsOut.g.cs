
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicModelsOut
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.AnthropicModelOut> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicModelsOut" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore"></param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicModelsOut(
            global::System.Collections.Generic.IList<global::DeepInfra.AnthropicModelOut> data,
            bool hasMore,
            string? firstId,
            string? lastId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.HasMore = hasMore;
            this.LastId = lastId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicModelsOut" /> class.
        /// </summary>
        public AnthropicModelsOut()
        {
        }

    }
}