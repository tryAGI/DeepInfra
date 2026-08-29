
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
        /// Pending requested max per type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_max_requests")]
        public global::System.Collections.Generic.Dictionary<string, int>? PendingMaxRequests { get; set; }

        /// <summary>
        /// Pending requested min per type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_min_requests")]
        public global::System.Collections.Generic.Dictionary<string, int>? PendingMinRequests { get; set; }

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
        /// <param name="pendingMaxRequests">
        /// Pending requested max per type
        /// </param>
        /// <param name="pendingMinRequests">
        /// Pending requested min per type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpuPoolOut(
            global::System.Collections.Generic.Dictionary<string, int>? maxLimits,
            global::System.Collections.Generic.Dictionary<string, int>? minLimits,
            global::System.Collections.Generic.Dictionary<string, int>? pendingMaxRequests,
            global::System.Collections.Generic.Dictionary<string, int>? pendingMinRequests)
        {
            this.MaxLimits = maxLimits;
            this.MinLimits = minLimits;
            this.PendingMaxRequests = pendingMaxRequests;
            this.PendingMinRequests = pendingMinRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolOut" /> class.
        /// </summary>
        public GpuPoolOut()
        {
        }

    }
}