
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PaymentMethodOut
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("card")]
        public global::DeepInfra.PaymentMethodCard? Card { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("us_bank_account")]
        public global::DeepInfra.PaymentMethodBank? UsBankAccount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cashapp")]
        public global::DeepInfra.PaymentMethodCashApp? Cashapp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodOut" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="card"></param>
        /// <param name="usBankAccount"></param>
        /// <param name="cashapp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentMethodOut(
            string type,
            global::DeepInfra.PaymentMethodCard? card,
            global::DeepInfra.PaymentMethodBank? usBankAccount,
            global::DeepInfra.PaymentMethodCashApp? cashapp)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Card = card;
            this.UsBankAccount = usBankAccount;
            this.Cashapp = cashapp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodOut" /> class.
        /// </summary>
        public PaymentMethodOut()
        {
        }

    }
}