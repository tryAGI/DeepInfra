#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Get Api Token
        /// </summary>
        /// <param name="apiToken"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ApiToken> GetApiTokenAsync(
            string apiToken,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}