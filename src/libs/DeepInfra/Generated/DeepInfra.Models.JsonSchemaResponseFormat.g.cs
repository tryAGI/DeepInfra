
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSchemaResponseFormat
    {
        /// <summary>
        /// Default Value: json_schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// JSON schema for structured output when type is 'json_schema'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::DeepInfra.JsonSchema JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: json_schema
        /// </param>
        /// <param name="jsonSchema">
        /// JSON schema for structured output when type is 'json_schema'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaResponseFormat(
            global::DeepInfra.JsonSchema jsonSchema,
            string? type)
        {
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaResponseFormat" /> class.
        /// </summary>
        public JsonSchemaResponseFormat()
        {
        }
    }
}