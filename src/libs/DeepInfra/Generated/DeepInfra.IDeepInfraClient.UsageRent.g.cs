#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Usage Rent
        /// </summary>
        /// <param name="from">
        /// start of period, in seconds since unix epoch
        /// </param>
        /// <param name="to">
        /// end of period, in seconds since unix epoch
        /// </param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.UsageRentOut> UsageRentAsync(
            int from,
            int? to = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}