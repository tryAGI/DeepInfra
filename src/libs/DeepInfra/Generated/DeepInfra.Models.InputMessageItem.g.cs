
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InputMessageItem
    {
        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.InputMessageItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.InputMessageItemRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageItem" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputMessageItem(
            global::DeepInfra.InputMessageItemRole role,
            global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.InputTextPart, global::DeepInfra.InputImagePart, global::DeepInfra.InputFilePart, global::DeepInfra.OutputTextPart>>> content,
            string? type,
            string? status)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageItem" /> class.
        /// </summary>
        public InputMessageItem()
        {
        }

    }
}