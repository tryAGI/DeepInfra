
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenClawBackupOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SnapshotName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_in_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeInGb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawBackupOut" /> class.
        /// </summary>
        /// <param name="snapshotName"></param>
        /// <param name="sizeInGb"></param>
        /// <param name="state"></param>
        /// <param name="createdAtUnix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenClawBackupOut(
            string snapshotName,
            int sizeInGb,
            string state,
            int createdAtUnix)
        {
            this.SnapshotName = snapshotName ?? throw new global::System.ArgumentNullException(nameof(snapshotName));
            this.SizeInGb = sizeInGb;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.CreatedAtUnix = createdAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenClawBackupOut" /> class.
        /// </summary>
        public OpenClawBackupOut()
        {
        }
    }
}