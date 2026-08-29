
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PaymentMethodCashApp
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cashtag")]
        public string? Cashtag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCashApp" /> class.
        /// </summary>
        /// <param name="cashtag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentMethodCashApp(
            string? cashtag)
        {
            this.Cashtag = cashtag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCashApp" /> class.
        /// </summary>
        public PaymentMethodCashApp()
        {
        }

    }
}