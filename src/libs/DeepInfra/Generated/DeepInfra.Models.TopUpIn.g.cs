
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopUpIn
    {
        /// <summary>
        /// Amount to top up in cents<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Top up threshold in cents, if balance goes below this value, top up will be triggered<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public int? Threshold { get; set; }

        /// <summary>
        /// If true, top up will be triggered when balance goes below threshold<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopUpIn" /> class.
        /// </summary>
        /// <param name="amount">
        /// Amount to top up in cents<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="threshold">
        /// Top up threshold in cents, if balance goes below this value, top up will be triggered<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="enabled">
        /// If true, top up will be triggered when balance goes below threshold<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopUpIn(
            int? amount,
            int? threshold,
            bool? enabled)
        {
            this.Amount = amount;
            this.Threshold = threshold;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopUpIn" /> class.
        /// </summary>
        public TopUpIn()
        {
        }
    }
}