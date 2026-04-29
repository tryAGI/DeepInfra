#nullable enable

namespace DeepInfra
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Create Voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.Voice> CreateVoiceAsync(

            global::DeepInfra.BodyCreateVoiceV1VoicesAddPost request,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="files"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.Voice> CreateVoiceAsync(
            string name,
            string description,
            global::System.Collections.Generic.IList<byte[]> files,
            string? xiApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}