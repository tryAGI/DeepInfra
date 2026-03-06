#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Get Request Costs
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.RequestCostResponse> GetRequestCostsAsync(

            global::DeepInfra.RequestCostQuery request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Request Costs
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="requestIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.RequestCostResponse> GetRequestCostsAsync(
            global::System.Collections.Generic.IList<string> requestIds,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}