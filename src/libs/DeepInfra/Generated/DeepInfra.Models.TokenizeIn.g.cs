
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
        /// add the tokenizer's special tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_special_tokens")]
        public bool? AddSpecialTokens { get; set; }

        /// <summary>
        /// append the assistant turn header (chat form)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_generation_prompt")]
        public bool? AddGenerationPrompt { get; set; }

        /// <summary>
        /// leave the final message open for continuation (chat form)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_final_message")]
        public bool? ContinueFinalMessage { get; set; }

        /// <summary>
        /// chat template override (chat form; the engine may refuse it)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_template")]
        public string? ChatTemplate { get; set; }

        /// <summary>
        /// extra variables for the chat template (chat form)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_template_kwargs")]
        public object? ChatTemplateKwargs { get; set; }

        /// <summary>
        /// tool definitions to render (chat form)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

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
        /// <param name="addSpecialTokens">
        /// add the tokenizer's special tokens
        /// </param>
        /// <param name="addGenerationPrompt">
        /// append the assistant turn header (chat form)
        /// </param>
        /// <param name="continueFinalMessage">
        /// leave the final message open for continuation (chat form)
        /// </param>
        /// <param name="chatTemplate">
        /// chat template override (chat form; the engine may refuse it)
        /// </param>
        /// <param name="chatTemplateKwargs">
        /// extra variables for the chat template (chat form)
        /// </param>
        /// <param name="tools">
        /// tool definitions to render (chat form)
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
            bool? addSpecialTokens,
            bool? addGenerationPrompt,
            bool? continueFinalMessage,
            string? chatTemplate,
            object? chatTemplateKwargs,
            global::System.Collections.Generic.IList<object>? tools,
            bool? returnTokenStrs)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt;
            this.Messages = messages;
            this.AddSpecialTokens = addSpecialTokens;
            this.AddGenerationPrompt = addGenerationPrompt;
            this.ContinueFinalMessage = continueFinalMessage;
            this.ChatTemplate = chatTemplate;
            this.ChatTemplateKwargs = chatTemplateKwargs;
            this.Tools = tools;
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