#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Delete Api Token
        /// </summary>
        /// <param name="apiToken"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteApiTokenAsync(
            string apiToken,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}