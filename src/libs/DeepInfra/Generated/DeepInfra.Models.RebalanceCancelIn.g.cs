
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RebalanceCancelIn
    {
        /// <summary>
        /// Rebalance to cancel; defaults to the active one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_id")]
        public string? ReplaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceCancelIn" /> class.
        /// </summary>
        /// <param name="replaceId">
        /// Rebalance to cancel; defaults to the active one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RebalanceCancelIn(
            string? replaceId)
        {
            this.ReplaceId = replaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceCancelIn" /> class.
        /// </summary>
        public RebalanceCancelIn()
        {
        }

    }
}