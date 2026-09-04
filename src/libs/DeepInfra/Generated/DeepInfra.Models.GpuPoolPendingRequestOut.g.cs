
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GpuPoolPendingRequestOut
    {
        /// <summary>
        /// Pass as expected_request_id to edit or cancel this
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
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_max")]
        public global::System.Collections.Generic.Dictionary<string, int>? RequestedMax { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolPendingRequestOut" /> class.
        /// </summary>
        /// <param name="id">
        /// Pass as expected_request_id to edit or cancel this
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="requestedMax"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpuPoolPendingRequestOut(
            string id,
            int createdAt,
            global::System.Collections.Generic.Dictionary<string, int>? requestedMax,
            string? reason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.RequestedMax = requestedMax;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolPendingRequestOut" /> class.
        /// </summary>
        public GpuPoolPendingRequestOut()
        {
        }

    }
}