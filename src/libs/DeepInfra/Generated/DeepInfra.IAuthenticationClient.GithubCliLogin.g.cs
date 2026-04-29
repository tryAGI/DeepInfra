#nullable enable

namespace DeepInfra
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Github Cli Login<br/>
        /// deepctl is calling this request waiting for auth token during login.<br/>
        /// The token is stored in /github/callback
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GithubCliLoginAsync(
            string loginId,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}