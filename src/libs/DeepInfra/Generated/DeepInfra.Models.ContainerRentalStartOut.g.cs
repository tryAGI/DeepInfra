
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerRentalStartOut
    {
        /// <summary>
        /// Container Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRentalStartOut" /> class.
        /// </summary>
        /// <param name="containerId">
        /// Container Id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerRentalStartOut(
            string containerId)
        {
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRentalStartOut" /> class.
        /// </summary>
        public ContainerRentalStartOut()
        {
        }
    }
}