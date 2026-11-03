
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiTokenScopesIn
    {
        /// <summary>
        /// what the key may do: at least one scope, never `unrestricted`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.Scope> Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenScopesIn" /> class.
        /// </summary>
        /// <param name="scopes">
        /// what the key may do: at least one scope, never `unrestricted`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiTokenScopesIn(
            global::System.Collections.Generic.IList<global::DeepInfra.Scope> scopes)
        {
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenScopesIn" /> class.
        /// </summary>
        public ApiTokenScopesIn()
        {
        }

    }
}