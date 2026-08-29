
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchOutputExpiresAfter
    {
        /// <summary>
        /// The anchor timestamp after which the expiration policy applies. Currently only created_at is supported.<br/>
        /// Default Value: created_at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        public string? Anchor { get; set; }

        /// <summary>
        /// The number of seconds after the anchor time that the output and error files will expire. Must be between 3600 (1 hour) and 2592000 (30 days).<br/>
        /// Default Value: 2592000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public int? Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchOutputExpiresAfter" /> class.
        /// </summary>
        /// <param name="anchor">
        /// The anchor timestamp after which the expiration policy applies. Currently only created_at is supported.<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="seconds">
        /// The number of seconds after the anchor time that the output and error files will expire. Must be between 3600 (1 hour) and 2592000 (30 days).<br/>
        /// Default Value: 2592000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchOutputExpiresAfter(
            string? anchor,
            int? seconds)
        {
            this.Anchor = anchor;
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchOutputExpiresAfter" /> class.
        /// </summary>
        public BatchOutputExpiresAfter()
        {
        }

    }
}