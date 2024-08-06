
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
        public bool Email { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_address")]
        public bool BillingAddress { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_method")]
        public bool PaymentMethod { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended")]
        public bool Suspended { get; set; } = false;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overdue_invoices")]
        public double OverdueInvoices { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_checked")]
        public int LastChecked { get; set; } = 0;

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
        public double Limit { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SuspendReasonJsonConverter))]
        public global::DeepInfra.SuspendReason? SuspendReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}