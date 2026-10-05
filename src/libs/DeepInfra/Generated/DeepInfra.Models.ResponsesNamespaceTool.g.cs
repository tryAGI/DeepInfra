
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesNamespaceTool
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"namespace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "namespace";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesNamespaceTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="tools"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesNamespaceTool(
            string name,
            string? description,
            global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ResponsesFunctionTool, object>>? tools,
            string type = "namespace")
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesNamespaceTool" /> class.
        /// </summary>
        public ResponsesNamespaceTool()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponsesNamespaceTool"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponsesNamespaceTool FromName(string name)
        {
            return new ResponsesNamespaceTool
            {
                Name = name,
            };
        }

    }
}