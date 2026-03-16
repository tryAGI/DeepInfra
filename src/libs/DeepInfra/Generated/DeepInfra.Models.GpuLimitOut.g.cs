
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GpuLimitOut
    {
        /// <summary>
        /// Effective GPU limits per type (defaults merged with overrides)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> Limits { get; set; }

        /// <summary>
        /// Pending GPU limit increase requests per type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_requests")]
        public global::System.Collections.Generic.Dictionary<string, int>? PendingRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuLimitOut" /> class.
        /// </summary>
        /// <param name="limits">
        /// Effective GPU limits per type (defaults merged with overrides)
        /// </param>
        /// <param name="pendingRequests">
        /// Pending GPU limit increase requests per type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpuLimitOut(
            global::System.Collections.Generic.Dictionary<string, int> limits,
            global::System.Collections.Generic.Dictionary<string, int>? pendingRequests)
        {
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
            this.PendingRequests = pendingRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuLimitOut" /> class.
        /// </summary>
        public GpuLimitOut()
        {
        }
    }
}