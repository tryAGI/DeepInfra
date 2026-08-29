#nullable enable

namespace DeepInfra
{
    public partial interface IDedicatedModelsClient
    {
        /// <summary>
        /// Deploy Rebalance<br/>
        /// Start a GPU pool rebalance: move GPUs from this deployment onto another<br/>
        /// deployment you own, one instance at a time and without downtime. Moving all<br/>
        /// instances stops this deployment; start it again later to resume it.
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.RebalanceOut> DeployRebalanceAsync(
            string deployId,

            global::DeepInfra.RebalanceIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy Rebalance<br/>
        /// Start a GPU pool rebalance: move GPUs from this deployment onto another<br/>
        /// deployment you own, one instance at a time and without downtime. Moving all<br/>
        /// instances stops this deployment; start it again later to resume it.
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.RebalanceOut>> DeployRebalanceAsResponseAsync(
            string deployId,

            global::DeepInfra.RebalanceIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy Rebalance<br/>
        /// Start a GPU pool rebalance: move GPUs from this deployment onto another<br/>
        /// deployment you own, one instance at a time and without downtime. Moving all<br/>
        /// instances stops this deployment; start it again later to resume it.
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="targetDeployId">
        /// Deployment to grow using GPUs freed from this one.
        /// </param>
        /// <param name="count">
        /// Number of target instances to create.
        /// </param>
        /// <param name="dryRun">
        /// Validate and preview without moving anything.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.RebalanceOut> DeployRebalanceAsync(
            string deployId,
            string targetDeployId,
            int count,
            string? xiApiKey = default,
            string? xApiKey = default,
            bool? dryRun = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}