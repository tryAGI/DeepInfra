
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenClawAgentFrameworkOut
    {
        /// <summary>
        /// Agent type identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Agent framework version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawAgentFrameworkOut" /> class.
        /// </summary>
        /// <param name="id">
        /// Agent type identifier
        /// </param>
        /// <param name="version">
        /// Agent framework version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenClawAgentFrameworkOut(
            string id,
            string version)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawAgentFrameworkOut" /> class.
        /// </summary>
        public OpenClawAgentFrameworkOut()
        {
        }

    }
}