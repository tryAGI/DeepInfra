
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// NVIDIA Member Lookup API result for one application, separate from its approval status.
    /// </summary>
    public sealed partial class InceptionMemberCheck
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.InceptionMemberCheckStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.InceptionMemberCheckStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_date")]
        public string? MemberDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("benefit_request_date")]
        public string? BenefitRequestDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checked_at")]
        public int? CheckedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_check_at")]
        public int? NextCheckAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InceptionMemberCheck" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="reason"></param>
        /// <param name="company"></param>
        /// <param name="memberDate"></param>
        /// <param name="benefitRequestDate"></param>
        /// <param name="checkedAt"></param>
        /// <param name="nextCheckAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InceptionMemberCheck(
            global::DeepInfra.InceptionMemberCheckStatus status,
            string? reason,
            string? company,
            string? memberDate,
            string? benefitRequestDate,
            int? checkedAt,
            int? nextCheckAt)
        {
            this.Status = status;
            this.Reason = reason;
            this.Company = company;
            this.MemberDate = memberDate;
            this.BenefitRequestDate = benefitRequestDate;
            this.CheckedAt = checkedAt;
            this.NextCheckAt = nextCheckAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InceptionMemberCheck" /> class.
        /// </summary>
        public InceptionMemberCheck()
        {
        }

    }
}