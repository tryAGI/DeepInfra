
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchErrors
    {
        /// <summary>
        /// The object type, which is always list.<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// List of error objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::DeepInfra.BatchErrorData>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchErrors" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always list.<br/>
        /// Default Value: list
        /// </param>
        /// <param name="data">
        /// List of error objects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchErrors(
            string? @object,
            global::System.Collections.Generic.IList<global::DeepInfra.BatchErrorData>? data)
        {
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchErrors" /> class.
        /// </summary>
        public BatchErrors()
        {
        }

    }
}