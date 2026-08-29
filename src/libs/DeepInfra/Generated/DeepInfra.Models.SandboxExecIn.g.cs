
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxExecIn
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>
        /// Seconds to allow the command to run before it's killed. 0 uses the server default (60s). Capped at 1800s (30 minutes).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxExecIn" /> class.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="timeoutSeconds">
        /// Seconds to allow the command to run before it's killed. 0 uses the server default (60s). Capped at 1800s (30 minutes).<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxExecIn(
            global::System.Collections.Generic.IList<string> command,
            int? timeoutSeconds)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxExecIn" /> class.
        /// </summary>
        public SandboxExecIn()
        {
        }

    }
}