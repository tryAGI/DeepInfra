
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// Your most recent decision, present only when it was a rejection. A later approval retires it; cancelling a later request does not.
    /// </summary>
    public sealed partial class GpuPoolOutLastRejection
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}