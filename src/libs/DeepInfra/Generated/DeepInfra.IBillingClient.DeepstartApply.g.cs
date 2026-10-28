#nullable enable

namespace DeepInfra
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Deepstart Apply
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeepStartApplicationOut> DeepstartApplyAsync(

            global::DeepInfra.DeepStartApplicationIn request,
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deepstart Apply
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.DeepStartApplicationOut>> DeepstartApplyAsResponseAsync(

            global::DeepInfra.DeepStartApplicationIn request,
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deepstart Apply
        /// </summary>
        /// <param name="session"></param>
        /// <param name="company"></param>
        /// <param name="ceo"></param>
        /// <param name="funding"></param>
        /// <param name="foundedOn"></param>
        /// <param name="website"></param>
        /// <param name="countryCode"></param>
        /// <param name="nvidiaConsent">
        /// Default Value: false
        /// </param>
        /// <param name="deal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeepStartApplicationOut> DeepstartApplyAsync(
            string company,
            string ceo,
            string funding,
            string foundedOn,
            string website,
            object? session = default,
            string? countryCode = default,
            bool? nvidiaConsent = default,
            string? deal = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}