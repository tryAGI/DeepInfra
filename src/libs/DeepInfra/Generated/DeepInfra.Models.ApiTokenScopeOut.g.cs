
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiTokenScopeOut
    {
        /// <summary>
        /// What an API key may do; a login session may do everything. Listed in the order the dashboard shows.<br/>
        /// A scope `x` also grants `x:read` (see `covers_scope`).<br/>
        /// Adding or renaming a scope needs its dashboard description in deepinfra/web too:<br/>
        /// `pages.dashboard.api_keys.scopes.descriptions.&lt;name with ':' as '_'&gt;` in<br/>
        /// public/locales/en/common.json. Without one the dashboard shows the bare name.<br/>
        /// Any change to this enum needs `./k8s_restart.sh token-verifier` before the callers that use<br/>
        /// it roll: token-verifier's create_api_token checks scopes with `key_scopes` against its own<br/>
        /// build, so until then it refuses a new scope with INVALID_ARGUMENT.<br/>
        /// A new scope is not initial, so unrestricted keys do not get it; one split from an<br/>
        /// initial scope is, so they keep what they could do.
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
        /// granted by the deprecated `unrestricted` scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_initial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInitial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenScopeOut" /> class.
        /// </summary>
        /// <param name="name">
        /// What an API key may do; a login session may do everything. Listed in the order the dashboard shows.<br/>
        /// A scope `x` also grants `x:read` (see `covers_scope`).<br/>
        /// Adding or renaming a scope needs its dashboard description in deepinfra/web too:<br/>
        /// `pages.dashboard.api_keys.scopes.descriptions.&lt;name with ':' as '_'&gt;` in<br/>
        /// public/locales/en/common.json. Without one the dashboard shows the bare name.<br/>
        /// Any change to this enum needs `./k8s_restart.sh token-verifier` before the callers that use<br/>
        /// it roll: token-verifier's create_api_token checks scopes with `key_scopes` against its own<br/>
        /// build, so until then it refuses a new scope with INVALID_ARGUMENT.<br/>
        /// A new scope is not initial, so unrestricted keys do not get it; one split from an<br/>
        /// initial scope is, so they keep what they could do.
        /// </param>
        /// <param name="isDefault">
        /// preselected for a new key
        /// </param>
        /// <param name="isInitial">
        /// granted by the deprecated `unrestricted` scope
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiTokenScopeOut(
            global::DeepInfra.Scope name,
            bool isDefault,
            bool isInitial)
        {
            this.Name = name;
            this.IsDefault = isDefault;
            this.IsInitial = isInitial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenScopeOut" /> class.
        /// </summary>
        public ApiTokenScopeOut()
        {
        }

    }
}