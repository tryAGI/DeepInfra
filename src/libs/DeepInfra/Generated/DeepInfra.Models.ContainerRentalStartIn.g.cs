
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerRentalStartIn
    {
        /// <summary>
        /// Container Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// GPU config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuConfig { get; set; }

        /// <summary>
        /// Container Image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerImage { get; set; }

        /// <summary>
        /// Cloud Init User Data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_init_user_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CloudInitUserData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRentalStartIn" /> class.
        /// </summary>
        /// <param name="name">
        /// Container Name
        /// </param>
        /// <param name="gpuConfig">
        /// GPU config
        /// </param>
        /// <param name="containerImage">
        /// Container Image
        /// </param>
        /// <param name="cloudInitUserData">
        /// Cloud Init User Data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerRentalStartIn(
            string name,
            string gpuConfig,
            string containerImage,
            string cloudInitUserData)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.GpuConfig = gpuConfig ?? throw new global::System.ArgumentNullException(nameof(gpuConfig));
            this.ContainerImage = containerImage ?? throw new global::System.ArgumentNullException(nameof(containerImage));
            this.CloudInitUserData = cloudInitUserData ?? throw new global::System.ArgumentNullException(nameof(cloudInitUserData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRentalStartIn" /> class.
        /// </summary>
        public ContainerRentalStartIn()
        {
        }
    }
}