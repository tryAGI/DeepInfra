
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitOut
    {
        /// <summary>
        /// Per model outstanding request rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RateLimit { get; set; }

        /// <summary>
        /// Per model token per minute rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_rate_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TpmRateLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOut" /> class.
        /// </summary>
        /// <param name="rateLimit">
        /// Per model outstanding request rate limit
        /// </param>
        /// <param name="tpmRateLimit">
        /// Per model token per minute rate limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitOut(
            int rateLimit,
            int tpmRateLimit)
        {
            this.RateLimit = rateLimit;
            this.TpmRateLimit = tpmRateLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOut" /> class.
        /// </summary>
        public RateLimitOut()
        {
        }
    }
}