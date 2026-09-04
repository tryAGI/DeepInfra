
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// The user's most recently rejected request
    /// </summary>
    public sealed partial class GpuPoolRejectionOut
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_at")]
        public int? ResolvedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_max")]
        public global::System.Collections.Generic.Dictionary<string, int>? RequestedMax { get; set; }

        /// <summary>
        /// Why the user requested the change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Why it was declined
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_reason")]
        public string? ResolutionReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolRejectionOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="resolvedAt"></param>
        /// <param name="requestedMax"></param>
        /// <param name="reason">
        /// Why the user requested the change
        /// </param>
        /// <param name="resolutionReason">
        /// Why it was declined
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpuPoolRejectionOut(
            string id,
            int createdAt,
            int? resolvedAt,
            global::System.Collections.Generic.Dictionary<string, int>? requestedMax,
            string? reason,
            string? resolutionReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ResolvedAt = resolvedAt;
            this.RequestedMax = requestedMax;
            this.Reason = reason;
            this.ResolutionReason = resolutionReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolRejectionOut" /> class.
        /// </summary>
        public GpuPoolRejectionOut()
        {
        }

    }
}