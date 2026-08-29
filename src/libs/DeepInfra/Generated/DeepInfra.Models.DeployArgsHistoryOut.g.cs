
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeployArgsHistoryOut
    {
        /// <summary>
        /// Identifier of this past config; pass it to POST /deploy/{deploy_id}/config/history/{entry_id}/restore.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entry_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntryId { get; set; }

        /// <summary>
        /// When this config was retired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retired_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RetiredAt { get; set; }

        /// <summary>
        /// Engine tuning knobs of this config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standard_args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object StandardArgs { get; set; }

        /// <summary>
        /// Extra engine-specific command-line args of this config (custom-weight deploys only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_args")]
        public global::System.Collections.Generic.IList<string>? ExtraArgs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployArgsHistoryOut" /> class.
        /// </summary>
        /// <param name="entryId">
        /// Identifier of this past config; pass it to POST /deploy/{deploy_id}/config/history/{entry_id}/restore.
        /// </param>
        /// <param name="retiredAt">
        /// When this config was retired.
        /// </param>
        /// <param name="standardArgs">
        /// Engine tuning knobs of this config.
        /// </param>
        /// <param name="extraArgs">
        /// Extra engine-specific command-line args of this config (custom-weight deploys only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeployArgsHistoryOut(
            string entryId,
            string retiredAt,
            object standardArgs,
            global::System.Collections.Generic.IList<string>? extraArgs)
        {
            this.EntryId = entryId ?? throw new global::System.ArgumentNullException(nameof(entryId));
            this.RetiredAt = retiredAt ?? throw new global::System.ArgumentNullException(nameof(retiredAt));
            this.StandardArgs = standardArgs ?? throw new global::System.ArgumentNullException(nameof(standardArgs));
            this.ExtraArgs = extraArgs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployArgsHistoryOut" /> class.
        /// </summary>
        public DeployArgsHistoryOut()
        {
        }

    }
}