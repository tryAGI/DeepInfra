
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomerRateLimitRequestsOut
    {
        /// <summary>
        /// Per model outstanding request rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RateLimit { get; set; }

        /// <summary>
        /// Whether a new request would be accepted: none is open, and the limit is below the self-serve maximum
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanRequest { get; set; }

        /// <summary>
        /// The request still waiting for an answer, even when it is older than the rows returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_request")]
        public global::DeepInfra.CustomerRateLimitRequestOut? OpenRequest { get; set; }

        /// <summary>
        /// Newest first
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.CustomerRateLimitRequestOut> Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRateLimitRequestsOut" /> class.
        /// </summary>
        /// <param name="rateLimit">
        /// Per model outstanding request rate limit
        /// </param>
        /// <param name="canRequest">
        /// Whether a new request would be accepted: none is open, and the limit is below the self-serve maximum
        /// </param>
        /// <param name="requests">
        /// Newest first
        /// </param>
        /// <param name="openRequest">
        /// The request still waiting for an answer, even when it is older than the rows returned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerRateLimitRequestsOut(
            int rateLimit,
            bool canRequest,
            global::System.Collections.Generic.IList<global::DeepInfra.CustomerRateLimitRequestOut> requests,
            global::DeepInfra.CustomerRateLimitRequestOut? openRequest)
        {
            this.RateLimit = rateLimit;
            this.CanRequest = canRequest;
            this.OpenRequest = openRequest;
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRateLimitRequestsOut" /> class.
        /// </summary>
        public CustomerRateLimitRequestsOut()
        {
        }

    }
}