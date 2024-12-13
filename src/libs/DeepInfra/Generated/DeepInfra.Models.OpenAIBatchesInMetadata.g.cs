
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Optional metadata to be stored with the batch.
    /// </summary>
    public sealed partial class OpenAIBatchesInMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIBatchesInMetadata" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OpenAIBatchesInMetadata(
 )
        {
        }
    }
}