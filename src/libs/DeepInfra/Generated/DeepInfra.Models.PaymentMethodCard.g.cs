
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PaymentMethodCard
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand")]
        public string? Brand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        public string? Last4 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wallet")]
        public string? Wallet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCard" /> class.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="last4"></param>
        /// <param name="wallet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentMethodCard(
            string? brand,
            string? last4,
            string? wallet)
        {
            this.Brand = brand;
            this.Last4 = last4;
            this.Wallet = wallet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCard" /> class.
        /// </summary>
        public PaymentMethodCard()
        {
        }

    }
}