#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Github Cli Login<br/>
        /// deepctl is calling this request waiting for auth token during login.<br/>
        /// The token is stored in /github/callback
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GithubCliLoginAsync(
            string loginId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}