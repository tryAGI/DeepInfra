
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionMessageToolCall
    {
        /// <summary>
        /// the id of the tool call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// the type of the tool call. only function is supported currently
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// the function that the model called
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.Function Function { get; set; }

        /// <summary>
        /// provider metadata returned with this tool call; send it back unchanged in history
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_content")]
        public object? ExtraContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// the id of the tool call
        /// </param>
        /// <param name="type">
        /// the type of the tool call. only function is supported currently
        /// </param>
        /// <param name="function">
        /// the function that the model called
        /// </param>
        /// <param name="extraContent">
        /// provider metadata returned with this tool call; send it back unchanged in history
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageToolCall(
            string id,
            string type,
            global::DeepInfra.Function function,
            object? extraContent)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.ExtraContent = extraContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageToolCall" /> class.
        /// </summary>
        public ChatCompletionMessageToolCall()
        {
        }

    }
}