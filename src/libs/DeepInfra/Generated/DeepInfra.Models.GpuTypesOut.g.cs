
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GpuTypesOut
    {
        /// <summary>
        /// GPU types to show in the pools UI, in display order. A guide, not a limit: a pool may hold types outside this list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepInfra.DeployGPUs> GpuTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuTypesOut" /> class.
        /// </summary>
        /// <param name="gpuTypes">
        /// GPU types to show in the pools UI, in display order. A guide, not a limit: a pool may hold types outside this list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpuTypesOut(
            global::System.Collections.Generic.IList<global::DeepInfra.DeployGPUs> gpuTypes)
        {
            this.GpuTypes = gpuTypes ?? throw new global::System.ArgumentNullException(nameof(gpuTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuTypesOut" /> class.
        /// </summary>
        public GpuTypesOut()
        {
        }

    }
}