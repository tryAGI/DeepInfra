
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GpuPoolRequestIn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_min")]
        public global::System.Collections.Generic.Dictionary<string, int>? RequestedMin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_max")]
        public global::System.Collections.Generic.Dictionary<string, int>? RequestedMax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolRequestIn" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="requestedMin"></param>
        /// <param name="requestedMax"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GpuPoolRequestIn(
            string reason,
            global::System.Collections.Generic.Dictionary<string, int>? requestedMin,
            global::System.Collections.Generic.Dictionary<string, int>? requestedMax)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.RequestedMin = requestedMin;
            this.RequestedMax = requestedMax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpuPoolRequestIn" /> class.
        /// </summary>
        public GpuPoolRequestIn()
        {
        }

    }
}