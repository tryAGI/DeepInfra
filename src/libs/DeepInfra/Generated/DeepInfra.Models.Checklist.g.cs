
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
        /// usage since most recent invoice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Recent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.SuspendReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.SuspendReason SuspendReason { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topup")]
        public bool? Topup { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topup_amount")]
        public int? TopupAmount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topup_threshold")]
        public int? TopupThreshold { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topup_failed")]
        public bool? TopupFailed { get; set; }

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
        /// <param name="recent">
        /// usage since most recent invoice
        /// </param>
        /// <param name="limit"></param>
        /// <param name="suspendReason"></param>
        /// <param name="topup">
        /// Default Value: false
        /// </param>
        /// <param name="topupAmount">
        /// Default Value: 0
        /// </param>
        /// <param name="topupThreshold">
        /// Default Value: 0
        /// </param>
        /// <param name="topupFailed">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Checklist(
            double stripeBalance,
            double recent,
            double? limit,
            global::DeepInfra.SuspendReason suspendReason,
            bool? email,
            bool? billingAddress,
            bool? paymentMethod,
            bool? suspended,
            double? overdueInvoices,
            int? lastChecked,
            bool? topup,
            int? topupAmount,
            int? topupThreshold,
            bool? topupFailed)
        {
            this.StripeBalance = stripeBalance;
            this.Recent = recent;
            this.Limit = limit;
            this.SuspendReason = suspendReason;
            this.Email = email;
            this.BillingAddress = billingAddress;
            this.PaymentMethod = paymentMethod;
            this.Suspended = suspended;
            this.OverdueInvoices = overdueInvoices;
            this.LastChecked = lastChecked;
            this.Topup = topup;
            this.TopupAmount = topupAmount;
            this.TopupThreshold = topupThreshold;
            this.TopupFailed = topupFailed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Checklist" /> class.
        /// </summary>
        public Checklist()
        {
        }
    }
}