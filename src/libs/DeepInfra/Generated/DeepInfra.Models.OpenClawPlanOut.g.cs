
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenClawPlanOut
    {
        /// <summary>
        /// Plan identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Number of vCPUs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Vcpu { get; set; }

        /// <summary>
        /// RAM in GB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ram_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RamGb { get; set; }

        /// <summary>
        /// Price in USD per hour
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
        /// Initializes a new instance of the <see cref="OpenClawPlanOut" /> class.
        /// </summary>
        /// <param name="id">
        /// Plan identifier
        /// </param>
        /// <param name="vcpu">
        /// Number of vCPUs
        /// </param>
        /// <param name="ramGb">
        /// RAM in GB
        /// </param>
        /// <param name="pricePerHour">
        /// Price in USD per hour
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenClawPlanOut(
            string id,
            int vcpu,
            int ramGb,
            double pricePerHour)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Vcpu = vcpu;
            this.RamGb = ramGb;
            this.PricePerHour = pricePerHour;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawPlanOut" /> class.
        /// </summary>
        public OpenClawPlanOut()
        {
        }

    }
}