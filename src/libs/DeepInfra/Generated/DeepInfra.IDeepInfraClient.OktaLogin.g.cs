#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Okta Login
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="origin"></param>
        /// <param name="loginId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OktaLoginAsync(
            string teamId,
            string? origin = default,
            string? loginId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}