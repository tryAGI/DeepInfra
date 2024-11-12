#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Github Login<br/>
        /// Initiate github SSO login flow. Callback is /github/callback
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="origin"></param>
        /// <param name="deal"></param>
        /// <param name="tiToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GithubLoginAsync(
            string? loginId = default,
            string? origin = default,
            string? deal = default,
            string? tiToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}