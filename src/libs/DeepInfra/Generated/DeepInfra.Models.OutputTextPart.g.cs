
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OutputTextPart
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"output_text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "output_text";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextPart" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputTextPart(
            string text,
            string type = "output_text")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextPart" /> class.
        /// </summary>
        public OutputTextPart()
        {
        }

        /// <summary>
        /// Creates a new <see cref="OutputTextPart"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static OutputTextPart FromText(string text)
        {
            return new OutputTextPart
            {
                Text = text,
            };
        }

    }
}