#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Account Set Username
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AccountSetUsernameV1MeUsernamePatchResponse> AccountSetUsernameAsync(
            global::DeepInfra.MeUsername request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Account Set Username
        /// </summary>
        /// <param name="username">
        /// String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AccountSetUsernameV1MeUsernamePatchResponse> AccountSetUsernameAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}