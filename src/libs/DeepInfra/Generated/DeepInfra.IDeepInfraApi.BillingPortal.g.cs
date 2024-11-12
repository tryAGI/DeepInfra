#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraApi
    {
        /// <summary>
        /// Billing Portal<br/>
        /// Redirect to the stripe billing portal page, where the user can manage<br/>
        /// their email and payment methods
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