#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Create Ssh Key
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.SshKeyOut> CreateSshKeyAsync(
            global::DeepInfra.SshKeyIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Ssh Key
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="name">
        /// SSH Key name
        /// </param>
        /// <param name="key">
        /// SSH Key content
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.SshKeyOut> CreateSshKeyAsync(
            string name,
            string key,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}