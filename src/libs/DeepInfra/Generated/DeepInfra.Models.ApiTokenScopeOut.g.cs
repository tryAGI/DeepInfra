
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiTokenScopeOut
    {
        /// <summary>
        /// What an API key may do. A scope `x` also grants `x:read`; `unrestricted` grants every non-sensitive scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.ScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.Scope Name { get; set; }

        /// <summary>
        /// preselected for a new key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// listed only for an account it is enabled for; no API key can grant it and `unrestricted` does not grant it<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_sensitive")]
        public bool? IsSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenScopeOut" /> class.
        /// </summary>
        /// <param name="name">
        /// What an API key may do. A scope `x` also grants `x:read`; `unrestricted` grants every non-sensitive scope.
        /// </param>
        /// <param name="isDefault">
        /// preselected for a new key
        /// </param>
        /// <param name="isSensitive">
        /// listed only for an account it is enabled for; no API key can grant it and `unrestricted` does not grant it<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiTokenScopeOut(
            global::DeepInfra.Scope name,
            bool isDefault,
            bool? isSensitive)
        {
            this.Name = name;
            this.IsDefault = isDefault;
            this.IsSensitive = isSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenScopeOut" /> class.
        /// </summary>
        public ApiTokenScopeOut()
        {
        }

    }
}