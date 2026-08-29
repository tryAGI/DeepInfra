#nullable enable

namespace DeepInfra
{
    public partial interface IDedicatedModelsClient
    {
        /// <summary>
        /// Deploy Rebalance Status<br/>
        /// Status of GPU pool rebalances touching this deployment. A just-started<br/>
        /// rebalance can take a moment to appear. A finished or cancelled rebalance<br/>
        /// leaves both deployments' min/max instances fixed at the final counts; edit<br/>
        /// them to resume autoscaling.
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.RebalanceStatusOut> DeployRebalanceStatusAsync(
            string deployId,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy Rebalance Status<br/>
        /// Status of GPU pool rebalances touching this deployment. A just-started<br/>
        /// rebalance can take a moment to appear. A finished or cancelled rebalance<br/>
        /// leaves both deployments' min/max instances fixed at the final counts; edit<br/>
        /// them to resume autoscaling.
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.RebalanceStatusOut>> DeployRebalanceStatusAsResponseAsync(
            string deployId,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}