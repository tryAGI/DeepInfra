
#nullable enable

namespace DeepInfra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TokenizeIn
    {
        /// <summary>
        /// model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// text to tokenize (completion form)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// chat messages to tokenize (chat form)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        /// also return the per-token strings (vLLM)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_token_strs")]
        public bool? ReturnTokenStrs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeIn" /> class.
        /// </summary>
        /// <param name="model">
        /// model name
        /// </param>
        /// <param name="prompt">
        /// text to tokenize (completion form)
        /// </param>
        /// <param name="messages">
        /// chat messages to tokenize (chat form)
        /// </param>
        /// <param name="returnTokenStrs">
        /// also return the per-token strings (vLLM)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizeIn(
            string model,
            string? prompt,
            global::System.Collections.Generic.IList<object>? messages,
            bool? returnTokenStrs)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt;
            this.Messages = messages;
            this.ReturnTokenStrs = returnTokenStrs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeIn" /> class.
        /// </summary>
        public TokenizeIn()
        {
        }

    }
}