
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// The number of dimensions in the embedding. If not provided, the model's default will be used.If provided bigger than model's default, the embedding will be padded with zeros.
    /// </summary>
    public sealed partial class OpenAIEmbeddingsInDimensions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}