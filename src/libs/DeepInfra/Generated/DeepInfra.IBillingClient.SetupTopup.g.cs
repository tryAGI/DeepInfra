#nullable enable

namespace DeepInfra
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Setup Topup
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetupTopupAsync(

            global::DeepInfra.TopUpIn request,
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetupTopupAsync(
            object? session = default,
            int? amount = default,
            int? threshold = default,
            bool? enabled = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}