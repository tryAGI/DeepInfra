
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddCardOut
    {
        /// <summary>
        /// Stripe Checkout Session URL that saves a card with its billing address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkout_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckoutUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCardOut" /> class.
        /// </summary>
        /// <param name="checkoutUrl">
        /// Stripe Checkout Session URL that saves a card with its billing address.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddCardOut(
            string checkoutUrl)
        {
            this.CheckoutUrl = checkoutUrl ?? throw new global::System.ArgumentNullException(nameof(checkoutUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCardOut" /> class.
        /// </summary>
        public AddCardOut()
        {
        }

    }
}