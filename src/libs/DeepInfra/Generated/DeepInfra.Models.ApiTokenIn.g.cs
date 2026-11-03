
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiTokenIn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<global::DeepInfra.Scope>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenIn" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="scopes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiTokenIn(
            string name,
            global::System.Collections.Generic.IList<global::DeepInfra.Scope>? scopes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenIn" /> class.
        /// </summary>
        public ApiTokenIn()
        {
        }

    }
}