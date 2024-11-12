
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPUAvailabilityInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usd_per_hour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsdPerHour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Available { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUAvailabilityInfo" /> class.
        /// </summary>
        /// <param name="gpuConfig"></param>
        /// <param name="usdPerHour"></param>
        /// <param name="available"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GPUAvailabilityInfo(
            string gpuConfig,
            double usdPerHour,
            bool available)
        {
            this.GpuConfig = gpuConfig ?? throw new global::System.ArgumentNullException(nameof(gpuConfig));
            this.UsdPerHour = usdPerHour;
            this.Available = available;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUAvailabilityInfo" /> class.
        /// </summary>
        public GPUAvailabilityInfo()
        {
        }
    }
}