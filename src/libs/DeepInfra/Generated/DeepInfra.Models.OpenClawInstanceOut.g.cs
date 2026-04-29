
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenClawInstanceOut
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.OpenClawInstanceStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.OpenClawInstanceState State { get; set; }

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
        public int? StopTs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_disk_size_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DataDiskSizeGb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_per_hour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PricePerHour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_backup_ts")]
        public int? LastBackupTs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SshPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_ip")]
        public string? PublicIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawInstanceOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="state"></param>
        /// <param name="startTs"></param>
        /// <param name="stateTs"></param>
        /// <param name="dataDiskSizeGb"></param>
        /// <param name="pricePerHour"></param>
        /// <param name="region"></param>
        /// <param name="sshPort"></param>
        /// <param name="stopTs"></param>
        /// <param name="lastBackupTs"></param>
        /// <param name="failReason"></param>
        /// <param name="publicIp"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenClawInstanceOut(
            string id,
            string name,
            global::DeepInfra.OpenClawInstanceState state,
            int startTs,
            int stateTs,
            int dataDiskSizeGb,
            double pricePerHour,
            string region,
            int sshPort,
            int? stopTs,
            int? lastBackupTs,
            string? failReason,
            string? publicIp,
            string? version)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.State = state;
            this.StartTs = startTs;
            this.StateTs = stateTs;
            this.StopTs = stopTs;
            this.DataDiskSizeGb = dataDiskSizeGb;
            this.PricePerHour = pricePerHour;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.LastBackupTs = lastBackupTs;
            this.SshPort = sshPort;
            this.FailReason = failReason;
            this.PublicIp = publicIp;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawInstanceOut" /> class.
        /// </summary>
        public OpenClawInstanceOut()
        {
        }
    }
}