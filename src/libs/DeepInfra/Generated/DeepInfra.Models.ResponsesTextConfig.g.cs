
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesTextConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<global::DeepInfra.ResponsesTextFormatText, global::DeepInfra.ResponsesTextFormatJsonObject, global::DeepInfra.ResponsesTextFormatJsonSchema, object>))]
        public global::DeepInfra.AnyOf<global::DeepInfra.ResponsesTextFormatText, global::DeepInfra.ResponsesTextFormatJsonObject, global::DeepInfra.ResponsesTextFormatJsonSchema, object>? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        public string? Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesTextConfig" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="verbosity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesTextConfig(
            global::DeepInfra.AnyOf<global::DeepInfra.ResponsesTextFormatText, global::DeepInfra.ResponsesTextFormatJsonObject, global::DeepInfra.ResponsesTextFormatJsonSchema, object>? format,
            string? verbosity)
        {
            this.Format = format;
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesTextConfig" /> class.
        /// </summary>
        public ResponsesTextConfig()
        {
        }

    }
}