
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiToken
    {
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
        /// `sk-di-`, or empty on a token minted before it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// display suffix; last 5 chars of the secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fragment")]
        public string? Fragment { get; set; }

        /// <summary>
        /// what the key may do<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<global::DeepInfra.Scope>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiToken" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// creation unix timestamp
        /// </param>
        /// <param name="name"></param>
        /// <param name="tokenId"></param>
        /// <param name="allowedIps"></param>
        /// <param name="prefix">
        /// `sk-di-`, or empty on a token minted before it
        /// </param>
        /// <param name="fragment">
        /// display suffix; last 5 chars of the secret
        /// </param>
        /// <param name="scopes">
        /// what the key may do<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiToken(
            global::System.DateTimeOffset createdAt,
            string name,
            string tokenId,
            global::System.Collections.Generic.IList<string>? allowedIps,
            string? prefix,
            string? fragment,
            global::System.Collections.Generic.IList<global::DeepInfra.Scope>? scopes)
        {
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.AllowedIps = allowedIps;
            this.Prefix = prefix;
            this.Fragment = fragment;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiToken" /> class.
        /// </summary>
        public ApiToken()
        {
        }

    }
}