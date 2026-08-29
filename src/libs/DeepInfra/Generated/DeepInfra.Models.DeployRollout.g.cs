
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeployRollout
    {
        /// <summary>
        /// Instances serving the current config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("up_to_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpToDate { get; set; }

        /// <summary>
        /// Instances still serving a previous config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outdated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Outdated { get; set; }

        /// <summary>
        /// Instances starting up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("booting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Booting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployRollout" /> class.
        /// </summary>
        /// <param name="upToDate">
        /// Instances serving the current config.
        /// </param>
        /// <param name="outdated">
        /// Instances still serving a previous config.
        /// </param>
        /// <param name="booting">
        /// Instances starting up.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeployRollout(
            int upToDate,
            int outdated,
            int booting)
        {
            this.UpToDate = upToDate;
            this.Outdated = outdated;
            this.Booting = booting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployRollout" /> class.
        /// </summary>
        public DeployRollout()
        {
        }

    }
}