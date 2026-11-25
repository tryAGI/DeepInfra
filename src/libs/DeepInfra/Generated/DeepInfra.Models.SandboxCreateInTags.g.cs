
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Key/value labels: at most 32 pairs, keys up to 64 bytes, values up to 256 bytes (UTF-8).
    /// </summary>
    public sealed partial class SandboxCreateInTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}