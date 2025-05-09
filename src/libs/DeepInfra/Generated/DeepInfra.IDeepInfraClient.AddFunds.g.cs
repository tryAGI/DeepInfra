#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Add Funds
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddFundsAsync(
            global::DeepInfra.AddFundsIn request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Funds
        /// </summary>
        /// <param name="session"></param>
        /// <param name="amount">
        /// Amount to add in USD
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddFundsAsync(
            double amount,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}