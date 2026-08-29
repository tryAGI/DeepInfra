
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchErrorData
    {
        /// <summary>
        /// An error code identifying the error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The line number of the input file where the error occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public int? Line { get; set; }

        /// <summary>
        /// A human-readable message describing the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The name of the parameter that caused the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchErrorData" /> class.
        /// </summary>
        /// <param name="code">
        /// An error code identifying the error type.
        /// </param>
        /// <param name="line">
        /// The line number of the input file where the error occurred.
        /// </param>
        /// <param name="message">
        /// A human-readable message describing the error.
        /// </param>
        /// <param name="param">
        /// The name of the parameter that caused the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchErrorData(
            string? code,
            int? line,
            string? message,
            string? param)
        {
            this.Code = code;
            this.Line = line;
            this.Message = message;
            this.Param = param;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchErrorData" /> class.
        /// </summary>
        public BatchErrorData()
        {
        }

    }
}