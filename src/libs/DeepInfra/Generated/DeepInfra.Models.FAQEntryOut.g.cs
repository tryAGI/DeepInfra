
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FAQEntryOut
    {
        /// <summary>
        /// FAQ entry ID, usually the question
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faq_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FaqId { get; set; }

        /// <summary>
        /// FAQ question
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// FAQ answer in markdown format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Answer { get; set; }

        /// <summary>
        /// order of the FAQ entry in the list, lower numbers come first<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FAQEntryOut" /> class.
        /// </summary>
        /// <param name="faqId">
        /// FAQ entry ID, usually the question
        /// </param>
        /// <param name="question">
        /// FAQ question
        /// </param>
        /// <param name="answer">
        /// FAQ answer in markdown format
        /// </param>
        /// <param name="order">
        /// order of the FAQ entry in the list, lower numbers come first<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FAQEntryOut(
            string faqId,
            string question,
            string answer,
            int? order)
        {
            this.FaqId = faqId ?? throw new global::System.ArgumentNullException(nameof(faqId));
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
            this.Order = order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FAQEntryOut" /> class.
        /// </summary>
        public FAQEntryOut()
        {
        }
    }
}