#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Setup Topup
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetupTopupAsync(
            global::DeepInfra.TopUpIn request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Setup Topup
        /// </summary>
        /// <param name="session"></param>
        /// <param name="amount">
        /// Amount to top up in cents<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="threshold">
        /// Top up threshold in cents, if balance goes below this value, top up will be triggered<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="enabled">
        /// If true, top up will be triggered when balance goes below threshold<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetupTopupAsync(
            string? session = default,
            int? amount = default,
            int? threshold = default,
            bool? enabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}