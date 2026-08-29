
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Role hint for asymmetric retrieval models: 'query' embeds a search query, 'passage'/'document' embeds a document. Controls the query:/passage: prefix on VL embedding models; ignored by symmetric models.
    /// </summary>
    public sealed partial class OpenAIEmbeddingsInInputType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}