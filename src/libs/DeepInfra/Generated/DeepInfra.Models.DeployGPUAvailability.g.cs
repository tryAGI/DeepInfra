
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployGPUAvailability
    {
        /// <summary>
        /// A list of all provided GPUs configurations, including their price and wether they are available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.GPUAvailabilityInfo> Gpus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployGPUAvailability" /> class.
        /// </summary>
        /// <param name="gpus">
        /// A list of all provided GPUs configurations, including their price and wether they are available
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeployGPUAvailability(
            global::System.Collections.Generic.IList<global::DeepInfra.GPUAvailabilityInfo> gpus)
        {
            this.Gpus = gpus ?? throw new global::System.ArgumentNullException(nameof(gpus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployGPUAvailability" /> class.
        /// </summary>
        public DeployGPUAvailability()
        {
        }
    }
}