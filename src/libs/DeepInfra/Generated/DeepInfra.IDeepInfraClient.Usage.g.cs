#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Usage
        /// </summary>
        /// <param name="from">
        /// start of period, YYYY.MM or current(-N) format
        /// </param>
        /// <param name="to">
        /// end of period (if missing a single month marked by from is return), same format as from
        /// </param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.UsageOut> UsageAsync(
            string from,
            string? to = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}