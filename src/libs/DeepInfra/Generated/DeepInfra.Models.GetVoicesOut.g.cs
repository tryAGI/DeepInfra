
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        public global::System.Collections.Generic.IList<global::DeepInfra.Voice>? Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesOut" /> class.
        /// </summary>
        /// <param name="voices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoicesOut(
            global::System.Collections.Generic.IList<global::DeepInfra.Voice>? voices)
        {
            this.Voices = voices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesOut" /> class.
        /// </summary>
        public GetVoicesOut()
        {
        }
    }
}