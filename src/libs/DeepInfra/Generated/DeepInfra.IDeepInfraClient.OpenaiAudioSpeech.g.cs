#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Openai Audio Speech
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiAudioSpeechAsync(

            global::DeepInfra.OpenAITextToSpeechIn request,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openai Audio Speech
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="serviceTier">
        /// The service tier used for processing the request. When set to 'priority', the request will be processed with higher priority (only applies to models that support it).
        /// </param>
        /// <param name="model">
        /// model name
        /// </param>
        /// <param name="input">
        /// Text to convert to speech
        /// </param>
        /// <param name="voice">
        /// Preset voices to use for the speech.
        /// </param>
        /// <param name="responseFormat">
        /// response format for the speech<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="speed">
        /// speed of the speech<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="extraBody">
        /// Extra body parameters for the model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiAudioSpeechAsync(
            string model,
            string input,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            global::DeepInfra.ServiceTier? serviceTier = default,
            string? voice = default,
            global::DeepInfra.TtsResponseFormat? responseFormat = default,
            double? speed = default,
            object? extraBody = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}