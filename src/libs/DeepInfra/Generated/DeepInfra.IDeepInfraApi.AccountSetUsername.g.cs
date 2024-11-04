#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Account Set Username
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AccountSetUsernameAsync(
            global::DeepInfra.MeUsername request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Account Set Username
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="username">
        /// String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AccountSetUsernameAsync(
            string username,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}