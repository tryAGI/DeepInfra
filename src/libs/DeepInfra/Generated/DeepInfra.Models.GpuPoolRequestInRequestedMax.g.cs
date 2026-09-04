
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Desired max GPUs per type, e.g. {"H100-80GB": 16}. REPLACES the contents of your pending request, so send every entry you still want changed.
    /// </summary>
    public sealed partial class GpuPoolRequestInRequestedMax
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}