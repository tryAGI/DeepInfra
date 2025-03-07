#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Update Voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.Voice2> UpdateVoiceAsync(
            string voiceId,
            global::DeepInfra.BodyUpdateVoiceV1VoicesVoiceIdEditPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.Voice2> UpdateVoiceAsync(
            string voiceId,
            string name,
            string description,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}