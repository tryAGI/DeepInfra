
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageRentOut
    {
        /// <summary>
        /// container id to duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_to_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> IdToDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageRentOut" /> class.
        /// </summary>
        /// <param name="idToDuration">
        /// container id to duration in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageRentOut(
            global::System.Collections.Generic.Dictionary<string, int> idToDuration)
        {
            this.IdToDuration = idToDuration ?? throw new global::System.ArgumentNullException(nameof(idToDuration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageRentOut" /> class.
        /// </summary>
        public UsageRentOut()
        {
        }
    }
}