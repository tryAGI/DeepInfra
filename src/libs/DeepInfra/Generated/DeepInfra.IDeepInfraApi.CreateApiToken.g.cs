#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Create Api Token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ApiToken> CreateApiTokenAsync(
            global::DeepInfra.ApiTokenIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Api Token
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ApiToken> CreateApiTokenAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}