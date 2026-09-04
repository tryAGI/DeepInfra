
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GpuPoolOut
    {
        /// <summary>
        /// Effective GPU max per type (pool, 0 if unset)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_limits")]
        public global::System.Collections.Generic.Dictionary<string, int>? MaxLimits { get; set; }

        /// <summary>
        /// Effective GPU min per type (pool, 0 if unset)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_limits")]
        public global::System.Collections.Generic.Dictionary<string, int>? MinLimits { get; set; }

        /// <summary>
        /// Your open request, if any. At most one exists at a time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_request")]
        public global::DeepInfra.GpuPoolPendingRequestOut? PendingRequest { get; set; }

        /// <summary>
        /// Your most recent decision, present only when it was a rejection. A later approval retires it; cancelling a later request does not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_rejection")]
        public global::DeepInfra.GpuPoolRejectionOut? LastRejection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolOut" /> class.
        /// </summary>
        /// <param name="maxLimits">
        /// Effective GPU max per type (pool, 0 if unset)
        /// </param>
        /// <param name="minLimits">
        /// Effective GPU min per type (pool, 0 if unset)
        /// </param>
        /// <param name="pendingRequest">
        /// Your open request, if any. At most one exists at a time.
        /// </param>
        /// <param name="lastRejection">
        /// Your most recent decision, present only when it was a rejection. A later approval retires it; cancelling a later request does not.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpuPoolOut(
            global::System.Collections.Generic.Dictionary<string, int>? maxLimits,
            global::System.Collections.Generic.Dictionary<string, int>? minLimits,
            global::DeepInfra.GpuPoolPendingRequestOut? pendingRequest,
            global::DeepInfra.GpuPoolRejectionOut? lastRejection)
        {
            this.MaxLimits = maxLimits;
            this.MinLimits = minLimits;
            this.PendingRequest = pendingRequest;
            this.LastRejection = lastRejection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolOut" /> class.
        /// </summary>
        public GpuPoolOut()
        {
        }

    }
}