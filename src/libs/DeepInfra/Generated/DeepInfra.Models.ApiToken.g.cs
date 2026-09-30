
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiToken
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// creation unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_ips")]
        public global::System.Collections.Generic.IList<string>? AllowedIps { get; set; }

        /// <summary>
        /// display suffix; last 5 chars of the secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fragment")]
        public string? Fragment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiToken" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="createdAt">
        /// creation unix timestamp
        /// </param>
        /// <param name="name"></param>
        /// <param name="tokenId"></param>
        /// <param name="allowedIps"></param>
        /// <param name="fragment">
        /// display suffix; last 5 chars of the secret
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiToken(
            string token,
            global::System.DateTimeOffset createdAt,
            string name,
            string tokenId,
            global::System.Collections.Generic.IList<string>? allowedIps,
            string? fragment)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.AllowedIps = allowedIps;
            this.Fragment = fragment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiToken" /> class.
        /// </summary>
        public ApiToken()
        {
        }

    }
}