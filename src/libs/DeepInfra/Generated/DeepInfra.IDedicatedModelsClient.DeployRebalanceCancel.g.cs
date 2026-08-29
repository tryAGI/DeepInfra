#nullable enable

namespace DeepInfra
{
    public partial interface IDedicatedModelsClient
    {
        /// <summary>
        /// Deploy Rebalance Cancel<br/>
        /// Stop an in-flight GPU pool rebalance; instances already moved stay, and<br/>
        /// both deployments keep min/max instances fixed at their current counts.
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.RebalanceCancelOut> DeployRebalanceCancelAsync(
            string deployId,

            global::DeepInfra.RebalanceCancelIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy Rebalance Cancel<br/>
        /// Stop an in-flight GPU pool rebalance; instances already moved stay, and<br/>
        /// both deployments keep min/max instances fixed at their current counts.
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.RebalanceCancelOut>> DeployRebalanceCancelAsResponseAsync(
            string deployId,

            global::DeepInfra.RebalanceCancelIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy Rebalance Cancel<br/>
        /// Stop an in-flight GPU pool rebalance; instances already moved stay, and<br/>
        /// both deployments keep min/max instances fixed at their current counts.
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.RebalanceCancelOut> DeployRebalanceCancelAsync(
            string deployId,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}