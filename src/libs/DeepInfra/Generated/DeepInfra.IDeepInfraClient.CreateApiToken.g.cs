#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Create Api Token
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ApiToken> CreateApiTokenAsync(
            global::DeepInfra.ApiTokenIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Api Token
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ApiToken> CreateApiTokenAsync(
            string name,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}