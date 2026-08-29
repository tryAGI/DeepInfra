
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PaymentMethodBank
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string? BankName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        public string? Last4 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodBank" /> class.
        /// </summary>
        /// <param name="bankName"></param>
        /// <param name="last4"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentMethodBank(
            string? bankName,
            string? last4)
        {
            this.BankName = bankName;
            this.Last4 = last4;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodBank" /> class.
        /// </summary>
        public PaymentMethodBank()
        {
        }

    }
}