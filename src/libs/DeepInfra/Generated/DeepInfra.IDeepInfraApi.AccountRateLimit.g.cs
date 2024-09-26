#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Account Rate Limit
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.RateLimitOut> AccountRateLimitAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}