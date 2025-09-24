#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Anthropic Messages
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AnthropicMessagesAsync(
            global::DeepInfra.AnthropicMessagesIn request,
            string? authorization = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Anthropic Messages
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="model"></param>
        /// <param name="maxTokens"></param>
        /// <param name="messages"></param>
        /// <param name="system"></param>
        /// <param name="stopSequences"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// Default Value: 1
        /// </param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        /// <param name="metadata"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="thinking"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AnthropicMessagesAsync(
            string model,
            global::System.Collections.Generic.IList<object> messages,
            string? authorization = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            int? maxTokens = default,
            global::DeepInfra.AnyOf<string, global::System.Collections.Generic.IList<global::DeepInfra.AnthropicSystemContent>>? system = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            bool? stream = default,
            double? temperature = default,
            double? topP = default,
            int? topK = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<global::DeepInfra.AnthropicTool>? tools = default,
            object? toolChoice = default,
            global::DeepInfra.AnthropicThinkingConfig? thinking = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}