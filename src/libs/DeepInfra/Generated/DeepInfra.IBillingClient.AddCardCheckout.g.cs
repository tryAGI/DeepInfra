#nullable enable

namespace DeepInfra
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Add Card Checkout<br/>
        /// Checkout page that saves a card, billing address included, so Add Funds<br/>
        /// can show it later.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AddCardOut> AddCardCheckoutAsync(
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Card Checkout<br/>
        /// Checkout page that saves a card, billing address included, so Add Funds<br/>
        /// can show it later.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.AddCardOut>> AddCardCheckoutAsResponseAsync(
            object? session = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}