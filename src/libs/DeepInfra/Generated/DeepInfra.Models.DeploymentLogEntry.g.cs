
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentLogEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentLogEntry" /> class.
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="line"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeploymentLogEntry(
            string ts,
            string line)
        {
            this.Ts = ts ?? throw new global::System.ArgumentNullException(nameof(ts));
            this.Line = line ?? throw new global::System.ArgumentNullException(nameof(line));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentLogEntry" /> class.
        /// </summary>
        public DeploymentLogEntry()
        {
        }
    }
}