
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KeyLimitIn
    {
        /// <summary>
        /// Api key id, as returned by /v1/api-tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        /// Monthly spending limit (in USD) for this key. Null or negative removes it; 0 blocks the key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyLimitIn" /> class.
        /// </summary>
        /// <param name="tokenId">
        /// Api key id, as returned by /v1/api-tokens
        /// </param>
        /// <param name="limit">
        /// Monthly spending limit (in USD) for this key. Null or negative removes it; 0 blocks the key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyLimitIn(
            string tokenId,
            double? limit)
        {
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyLimitIn" /> class.
        /// </summary>
        public KeyLimitIn()
        {
        }

    }
}