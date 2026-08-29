
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Engine tuning knobs. Values are validated on submission; unsupported or out-of-range values are rejected. Unset knobs use the model/engine defaults.
    /// </summary>
    public sealed partial class DeployLLMInStandardArgs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}