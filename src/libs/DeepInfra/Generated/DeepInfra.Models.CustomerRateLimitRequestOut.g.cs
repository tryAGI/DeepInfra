
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// One request as its own account sees it. Every field is required, so that<br/>
    /// each is set on purpose: the rest of the row is not a customer's to read.
    /// </summary>
    public sealed partial class CustomerRateLimitRequestOut
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_rate_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestedRateLimit { get; set; }

        /// <summary>
        /// The limit in force when the request was filed; null on older requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_at_request")]
        public int? RateLimitAtRequest { get; set; }

        /// <summary>
        /// What the requester wrote
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// What an account is shown for one of its own requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.RateLimitRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.RateLimitRequestState State { get; set; }

        /// <summary>
        /// When it was answered, where that was recorded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decided_at")]
        public int? DecidedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_rate_limit")]
        public int? GrantedRateLimit { get; set; }

        /// <summary>
        /// The email that gave the answer `state` names, as it was sent; null when that email was not sent or is not kept, and for every other state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// False when a teammate filed it for the same account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_by_you")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequestedByYou { get; set; }

        /// <summary>
        /// Whether you may cancel it: it still waits for an answer, and you filed it, are an admin of its team, or are the account it belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_cancel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanCancel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRateLimitRequestOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="requestedRateLimit"></param>
        /// <param name="state">
        /// What an account is shown for one of its own requests.
        /// </param>
        /// <param name="requestedByYou">
        /// False when a teammate filed it for the same account
        /// </param>
        /// <param name="canCancel">
        /// Whether you may cancel it: it still waits for an answer, and you filed it, are an admin of its team, or are the account it belongs to
        /// </param>
        /// <param name="rateLimitAtRequest">
        /// The limit in force when the request was filed; null on older requests
        /// </param>
        /// <param name="reason">
        /// What the requester wrote
        /// </param>
        /// <param name="decidedAt">
        /// When it was answered, where that was recorded
        /// </param>
        /// <param name="grantedRateLimit"></param>
        /// <param name="message">
        /// The email that gave the answer `state` names, as it was sent; null when that email was not sent or is not kept, and for every other state
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerRateLimitRequestOut(
            string id,
            int createdAt,
            int requestedRateLimit,
            global::DeepInfra.RateLimitRequestState state,
            bool requestedByYou,
            bool canCancel,
            int? rateLimitAtRequest,
            string? reason,
            int? decidedAt,
            int? grantedRateLimit,
            string? message)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.RequestedRateLimit = requestedRateLimit;
            this.RateLimitAtRequest = rateLimitAtRequest;
            this.Reason = reason;
            this.State = state;
            this.DecidedAt = decidedAt;
            this.GrantedRateLimit = grantedRateLimit;
            this.Message = message;
            this.RequestedByYou = requestedByYou;
            this.CanCancel = canCancel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRateLimitRequestOut" /> class.
        /// </summary>
        public CustomerRateLimitRequestOut()
        {
        }

    }
}