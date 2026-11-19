
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NewCustomerLimits
    {
        /// <summary>
        /// Most that can be added in one payment now, in cents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxAmount { get; set; }

        /// <summary>
        /// Add-funds payments still allowed; 0 means none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payments_left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PaymentsLeft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewCustomerLimits" /> class.
        /// </summary>
        /// <param name="maxAmount">
        /// Most that can be added in one payment now, in cents
        /// </param>
        /// <param name="paymentsLeft">
        /// Add-funds payments still allowed; 0 means none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewCustomerLimits(
            int maxAmount,
            int paymentsLeft)
        {
            this.MaxAmount = maxAmount;
            this.PaymentsLeft = paymentsLeft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewCustomerLimits" /> class.
        /// </summary>
        public NewCustomerLimits()
        {
        }

    }
}