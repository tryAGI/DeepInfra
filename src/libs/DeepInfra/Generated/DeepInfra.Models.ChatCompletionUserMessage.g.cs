
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepInfra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessage
    {
        /// <summary>
        /// Cache control for prompt caching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public object? CacheControl { get; set; }

        /// <summary>
        /// the role of the author of this message<br/>
        /// Default Value: user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.ChatCompletionUserMessageRoleJsonConverter))]
        public global::DeepInfra.ChatCompletionUserMessageRole? Role { get; set; }

        /// <summary>
        /// the message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepInfra.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessage" /> class.
        /// </summary>
        /// <param name="cacheControl">
        /// Cache control for prompt caching
        /// </param>
        /// <param name="role">
        /// the role of the author of this message<br/>
        /// Default Value: user
        /// </param>
        /// <param name="content">
        /// the message content
        /// </param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessage(
            global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnyOf<global::DeepInfra.ChatCompletionContentPartText, global::DeepInfra.ChatCompletionContentPartImage, global::DeepInfra.ChatCompletionContentPartAudio>>> content,
            object? cacheControl,
            global::DeepInfra.ChatCompletionUserMessageRole? role,
            string? name)
        {
            this.Content = content;
            this.CacheControl = cacheControl;
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessage" /> class.
        /// </summary>
        public ChatCompletionUserMessage()
        {
        }
    }
}