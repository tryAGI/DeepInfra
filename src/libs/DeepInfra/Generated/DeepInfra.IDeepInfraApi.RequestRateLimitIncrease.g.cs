#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Request Rate Limit Increase
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RequestRateLimitIncreaseAsync(
            global::DeepInfra.RateLimitRequestIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Request Rate Limit Increase
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="rateLimit"></param>
        /// <param name="reason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RequestRateLimitIncreaseAsync(
            int rateLimit,
            string reason,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}