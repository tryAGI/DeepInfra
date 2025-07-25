
#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatTools
    {
        /// <summary>
        /// Cache control for prompt caching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public object? CacheControl { get; set; }

        /// <summary>
        /// Default Value: function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.FunctionDefinition Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTools" /> class.
        /// </summary>
        /// <param name="cacheControl">
        /// Cache control for prompt caching
        /// </param>
        /// <param name="type">
        /// Default Value: function
        /// </param>
        /// <param name="function"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatTools(
            global::DeepInfra.FunctionDefinition function,
            object? cacheControl,
            string? type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.CacheControl = cacheControl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTools" /> class.
        /// </summary>
        public ChatTools()
        {
        }
    }
}