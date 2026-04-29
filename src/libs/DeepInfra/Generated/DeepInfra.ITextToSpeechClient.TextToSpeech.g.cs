#nullable enable

namespace DeepInfra
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Text To Speech
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="outputFormat"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TextToSpeechAsync(
            string voiceId,

            global::DeepInfra.ElevenLabsTextToSpeechIn request,
            string? outputFormat = default,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text To Speech
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="outputFormat"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="text">
        /// Text to convert to speech
        /// </param>
        /// <param name="modelId">
        /// Model ID to use for the conversion<br/>
        /// Default Value: hexgrad/Kokoro-82M
        /// </param>
        /// <param name="requestOutputFormat">
        /// Output format for the speech<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="languageCode">
        /// ISO 639-1, 2 letter language code
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TextToSpeechAsync(
            string voiceId,
            string text,
            string? outputFormat = default,
            string? xiApiKey = default,
            string? modelId = default,
            global::DeepInfra.TtsResponseFormat? requestOutputFormat = default,
            string? languageCode = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}