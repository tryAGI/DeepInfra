
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RebalanceCancelOut
    {
        /// <summary>
        /// Id of the cancelled rebalance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplaceId { get; set; }

        /// <summary>
        /// Target instances delivered before the cancel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Placed { get; set; }

        /// <summary>
        /// Target instances requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceCancelOut" /> class.
        /// </summary>
        /// <param name="replaceId">
        /// Id of the cancelled rebalance.
        /// </param>
        /// <param name="placed">
        /// Target instances delivered before the cancel.
        /// </param>
        /// <param name="count">
        /// Target instances requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RebalanceCancelOut(
            string replaceId,
            int placed,
            int count)
        {
            this.ReplaceId = replaceId ?? throw new global::System.ArgumentNullException(nameof(replaceId));
            this.Placed = placed;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceCancelOut" /> class.
        /// </summary>
        public RebalanceCancelOut()
        {
        }

    }
}