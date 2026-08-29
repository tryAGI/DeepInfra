
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxPlanOut
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Vcpu { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ram_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RamGb { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DiskGb { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_per_hour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PricePerHour { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPlanOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="vcpu"></param>
        /// <param name="ramGb"></param>
        /// <param name="diskGb"></param>
        /// <param name="pricePerHour"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxPlanOut(
            string id,
            int vcpu,
            int ramGb,
            int diskGb,
            double pricePerHour)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Vcpu = vcpu;
            this.RamGb = ramGb;
            this.DiskGb = diskGb;
            this.PricePerHour = pricePerHour;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPlanOut" /> class.
        /// </summary>
        public SandboxPlanOut()
        {
        }

    }
}