
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenClawExpandStorageIn
    {
        /// <summary>
        /// New disk size in GB (must be larger than current)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_size_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NewSizeGb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawExpandStorageIn" /> class.
        /// </summary>
        /// <param name="newSizeGb">
        /// New disk size in GB (must be larger than current)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenClawExpandStorageIn(
            int newSizeGb)
        {
            this.NewSizeGb = newSizeGb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawExpandStorageIn" /> class.
        /// </summary>
        public OpenClawExpandStorageIn()
        {
        }
    }
}