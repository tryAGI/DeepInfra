
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HardwareResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        public global::System.Collections.Generic.IList<global::DeepInfra.HardwareOption>? Hardware { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareResponse" /> class.
        /// </summary>
        /// <param name="hardware"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HardwareResponse(
            global::System.Collections.Generic.IList<global::DeepInfra.HardwareOption>? hardware)
        {
            this.Hardware = hardware;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareResponse" /> class.
        /// </summary>
        public HardwareResponse()
        {
        }
    }
}