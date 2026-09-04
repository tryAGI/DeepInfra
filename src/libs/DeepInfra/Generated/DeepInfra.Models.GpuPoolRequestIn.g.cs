
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GpuPoolRequestIn
    {
        /// <summary>
        /// Why you need the change. Shown to the reviewer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Guaranteed capacity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_min")]
        public global::System.Collections.Generic.Dictionary<string, int>? RequestedMin { get; set; }

        /// <summary>
        /// Desired max GPUs per type, e.g. {"H100-80GB": 16}. REPLACES the contents of your pending request, so send every entry you still want changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_max")]
        public global::System.Collections.Generic.Dictionary<string, int>? RequestedMax { get; set; }

        /// <summary>
        /// Id of the pending request you are editing, from GET /v1/me/gpu_pool (pending_request.id), or null if you have none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_request_id")]
        public string? ExpectedRequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolRequestIn" /> class.
        /// </summary>
        /// <param name="reason">
        /// Why you need the change. Shown to the reviewer.
        /// </param>
        /// <param name="requestedMin">
        /// Guaranteed capacity.
        /// </param>
        /// <param name="requestedMax">
        /// Desired max GPUs per type, e.g. {"H100-80GB": 16}. REPLACES the contents of your pending request, so send every entry you still want changed.
        /// </param>
        /// <param name="expectedRequestId">
        /// Id of the pending request you are editing, from GET /v1/me/gpu_pool (pending_request.id), or null if you have none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpuPoolRequestIn(
            string reason,
            global::System.Collections.Generic.Dictionary<string, int>? requestedMin,
            global::System.Collections.Generic.Dictionary<string, int>? requestedMax,
            string? expectedRequestId)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.RequestedMin = requestedMin;
            this.RequestedMax = requestedMax;
            this.ExpectedRequestId = expectedRequestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolRequestIn" /> class.
        /// </summary>
        public GpuPoolRequestIn()
        {
        }

    }
}