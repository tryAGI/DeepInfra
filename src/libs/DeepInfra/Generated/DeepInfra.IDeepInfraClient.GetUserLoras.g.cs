#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Get User Loras
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetUserLorasAsync(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}