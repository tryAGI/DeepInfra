
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Checklist
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public bool? Email { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_address")]
        public bool? BillingAddress { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_method")]
        public bool? PaymentMethod { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended")]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overdue_invoices")]
        public double? OverdueInvoices { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_checked")]
        public int? LastChecked { get; set; }

        /// <summary>
        /// Negative value indicates funds ready-to-spend. Positive value indicates money owed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StripeBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.SuspendReasonJsonConverter))]
        public global::DeepInfra.SuspendReason? SuspendReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Checklist" /> class.
        /// </summary>
        /// <param name="email">
        /// Default Value: false
        /// </param>
        /// <param name="billingAddress">
        /// Default Value: false
        /// </param>
        /// <param name="paymentMethod">
        /// Default Value: false
        /// </param>
        /// <param name="suspended">
        /// Default Value: false
        /// </param>
        /// <param name="overdueInvoices">
        /// Default Value: 0
        /// </param>
        /// <param name="lastChecked">
        /// Default Value: 0
        /// </param>
        /// <param name="stripeBalance">
        /// Negative value indicates funds ready-to-spend. Positive value indicates money owed
        /// </param>
        /// <param name="limit"></param>
        /// <param name="suspendReason">
        /// An enumeration.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Checklist(
            double stripeBalance,
            bool? email,
            bool? billingAddress,
            bool? paymentMethod,
            bool? suspended,
            double? overdueInvoices,
            int? lastChecked,
            double? limit,
            global::DeepInfra.SuspendReason? suspendReason)
        {
            this.StripeBalance = stripeBalance;
            this.Email = email;
            this.BillingAddress = billingAddress;
            this.PaymentMethod = paymentMethod;
            this.Suspended = suspended;
            this.OverdueInvoices = overdueInvoices;
            this.LastChecked = lastChecked;
            this.Limit = limit;
            this.SuspendReason = suspendReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Checklist" /> class.
        /// </summary>
        public Checklist()
        {
        }
    }
}