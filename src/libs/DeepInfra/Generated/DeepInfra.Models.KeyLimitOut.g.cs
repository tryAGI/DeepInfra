
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KeyLimitOut
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        /// Api key name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Monthly spending limit (in USD), if set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Spent so far this month (in USD). Null when not yet computed for this key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyLimitOut" /> class.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="name">
        /// Api key name
        /// </param>
        /// <param name="limit">
        /// Monthly spending limit (in USD), if set
        /// </param>
        /// <param name="spend">
        /// Spent so far this month (in USD). Null when not yet computed for this key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyLimitOut(
            string tokenId,
            string name,
            double? limit,
            double? spend)
        {
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Limit = limit;
            this.Spend = spend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyLimitOut" /> class.
        /// </summary>
        public KeyLimitOut()
        {
        }

    }
}