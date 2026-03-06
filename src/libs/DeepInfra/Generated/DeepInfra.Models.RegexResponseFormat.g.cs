
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegexResponseFormat
    {
        /// <summary>
        /// Default Value: regex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.RegexResponseFormatTypeJsonConverter))]
        public global::DeepInfra.RegexResponseFormatType? Type { get; set; }

        /// <summary>
        /// Regex pattern for structured output when type is 'regex'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Regex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: regex
        /// </param>
        /// <param name="regex">
        /// Regex pattern for structured output when type is 'regex'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegexResponseFormat(
            string regex,
            global::DeepInfra.RegexResponseFormatType? type)
        {
            this.Regex = regex ?? throw new global::System.ArgumentNullException(nameof(regex));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexResponseFormat" /> class.
        /// </summary>
        public RegexResponseFormat()
        {
        }
    }
}