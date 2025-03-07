#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Set Config
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ConfigOut> SetConfigAsync(
            global::DeepInfra.ConfigIn request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set Config
        /// </summary>
        /// <param name="session"></param>
        /// <param name="limit">
        /// Set usage limit (in USD). Negative means no limit.null/not-set means don't change it
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.ConfigOut> SetConfigAsync(
            string? session = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}