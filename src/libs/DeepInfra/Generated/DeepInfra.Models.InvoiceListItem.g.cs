
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InvoiceListItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_due")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AmountDue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("due_date")]
        public int? DueDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        public string? Period { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_type")]
        public string? InvoiceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosted_invoice_url")]
        public string? HostedInvoiceUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_pdf")]
        public string? InvoicePdf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceListItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="total"></param>
        /// <param name="amountDue"></param>
        /// <param name="created"></param>
        /// <param name="dueDate"></param>
        /// <param name="period"></param>
        /// <param name="invoiceType"></param>
        /// <param name="hostedInvoiceUrl"></param>
        /// <param name="invoicePdf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvoiceListItem(
            string id,
            string status,
            int total,
            int amountDue,
            int created,
            int? dueDate,
            string? period,
            string? invoiceType,
            string? hostedInvoiceUrl,
            string? invoicePdf)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Total = total;
            this.AmountDue = amountDue;
            this.Created = created;
            this.DueDate = dueDate;
            this.Period = period;
            this.InvoiceType = invoiceType;
            this.HostedInvoiceUrl = hostedInvoiceUrl;
            this.InvoicePdf = invoicePdf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceListItem" /> class.
        /// </summary>
        public InvoiceListItem()
        {
        }

    }
}