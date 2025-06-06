
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerRentalOut
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.ContainerRentalStateOutJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.ContainerRentalStateOut State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StateTs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? StopTs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GpuConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_per_hour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PricePerHour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? FailReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRentalOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="state"></param>
        /// <param name="startTs"></param>
        /// <param name="stateTs"></param>
        /// <param name="stopTs"></param>
        /// <param name="ip"></param>
        /// <param name="gpuConfig"></param>
        /// <param name="pricePerHour"></param>
        /// <param name="containerImage"></param>
        /// <param name="failReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerRentalOut(
            string id,
            string name,
            global::DeepInfra.ContainerRentalStateOut state,
            int startTs,
            int stateTs,
            int? stopTs,
            string? ip,
            string gpuConfig,
            double pricePerHour,
            string containerImage,
            string? failReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.State = state;
            this.StartTs = startTs;
            this.StateTs = stateTs;
            this.StopTs = stopTs;
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.GpuConfig = gpuConfig ?? throw new global::System.ArgumentNullException(nameof(gpuConfig));
            this.PricePerHour = pricePerHour;
            this.ContainerImage = containerImage ?? throw new global::System.ArgumentNullException(nameof(containerImage));
            this.FailReason = failReason ?? throw new global::System.ArgumentNullException(nameof(failReason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRentalOut" /> class.
        /// </summary>
        public ContainerRentalOut()
        {
        }
    }
}