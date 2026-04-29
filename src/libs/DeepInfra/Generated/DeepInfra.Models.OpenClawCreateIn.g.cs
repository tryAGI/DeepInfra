
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenClawCreateIn
    {
        /// <summary>
        /// Instance name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Data disk size in GB. Can be expanded later.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_disk_size_gb")]
        public int? DataDiskSizeGb { get; set; }

        /// <summary>
        /// AWS region<br/>
        /// Default Value: us-west-2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawCreateIn" /> class.
        /// </summary>
        /// <param name="name">
        /// Instance name
        /// </param>
        /// <param name="dataDiskSizeGb">
        /// Data disk size in GB. Can be expanded later.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="region">
        /// AWS region<br/>
        /// Default Value: us-west-2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenClawCreateIn(
            string name,
            int? dataDiskSizeGb,
            string? region)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataDiskSizeGb = dataDiskSizeGb;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawCreateIn" /> class.
        /// </summary>
        public OpenClawCreateIn()
        {
        }
    }
}