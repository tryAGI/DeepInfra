#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Billing Portal
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.BillingPortalOut> BillingPortalAsync(
            string? returnUrl = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}