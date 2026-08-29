
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RebalanceStatusOut
    {
        /// <summary>
        /// The in-flight rebalance touching this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public global::DeepInfra.RebalanceStatus? Active { get; set; }

        /// <summary>
        /// Finished rebalances, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent")]
        public global::System.Collections.Generic.IList<global::DeepInfra.RebalanceStatus>? Recent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceStatusOut" /> class.
        /// </summary>
        /// <param name="active">
        /// The in-flight rebalance touching this deployment.
        /// </param>
        /// <param name="recent">
        /// Finished rebalances, newest first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RebalanceStatusOut(
            global::DeepInfra.RebalanceStatus? active,
            global::System.Collections.Generic.IList<global::DeepInfra.RebalanceStatus>? recent)
        {
            this.Active = active;
            this.Recent = recent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RebalanceStatusOut" /> class.
        /// </summary>
        public RebalanceStatusOut()
        {
        }

    }
}