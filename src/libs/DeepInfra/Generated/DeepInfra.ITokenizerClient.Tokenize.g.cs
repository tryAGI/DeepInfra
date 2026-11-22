#nullable enable

namespace DeepInfra
{
    public partial interface ITokenizerClient
    {
        /// <summary>
        /// Tokenize
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.TokenizeOut> TokenizeAsync(

            global::DeepInfra.TokenizeIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.TokenizeOut>> TokenizeAsResponseAsync(

            global::DeepInfra.TokenizeIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.TokenizeOut> TokenizeAsync(
            string model,
            string? xiApiKey = default,
            string? xApiKey = default,
            string? prompt = default,
            global::System.Collections.Generic.IList<object>? messages = default,
            bool? addSpecialTokens = default,
            bool? addGenerationPrompt = default,
            bool? continueFinalMessage = default,
            string? chatTemplate = default,
            object? chatTemplateKwargs = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            bool? returnTokenStrs = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}