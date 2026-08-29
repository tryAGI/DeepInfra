
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddFundsOut
    {
        /// <summary>
        /// Stripe Checkout Session URL to complete payment. Non-null when no saved payment method is on file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkout_url")]
        public string? CheckoutUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFundsOut" /> class.
        /// </summary>
        /// <param name="checkoutUrl">
        /// Stripe Checkout Session URL to complete payment. Non-null when no saved payment method is on file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddFundsOut(
            string? checkoutUrl)
        {
            this.CheckoutUrl = checkoutUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFundsOut" /> class.
        /// </summary>
        public AddFundsOut()
        {
        }

    }
}