#nullable enable

namespace DeepInfra
{
    public partial interface IDedicatedModelsClient
    {
        /// <summary>
        /// Deploy Rebalance<br/>
        /// Start a GPU pool rebalance: move GPUs from this deployment onto another<br/>
        /// deployment you own, a target instance at a time unless concurrency raises it.<br/>
        /// A source instance is never left half-moved, so one larger target instance stops<br/>
        /// several of this deployment's at once, and one larger source instance is replaced<br/>
        /// by several target instances at once. Moving all instances stops this deployment;<br/>
        /// start it again later to resume it.
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
        /// deployment you own, a target instance at a time unless concurrency raises it.<br/>
        /// A source instance is never left half-moved, so one larger target instance stops<br/>
        /// several of this deployment's at once, and one larger source instance is replaced<br/>
        /// by several target instances at once. Moving all instances stops this deployment;<br/>
        /// start it again later to resume it.
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
        /// deployment you own, a target instance at a time unless concurrency raises it.<br/>
        /// A source instance is never left half-moved, so one larger target instance stops<br/>
        /// several of this deployment's at once, and one larger source instance is replaced<br/>
        /// by several target instances at once. Moving all instances stops this deployment;<br/>
        /// start it again later to resume it.
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
        /// <param name="concurrency">
        /// How many target instances may start at once (default 1). Higher finishes sooner at a deeper dip in source capacity; clamped to count. How many source instances that takes down depends on their relative size: one target instance the size of 4 source instances stops 4 of them at once, while a source instance that yields 4 target instances is always drained in one go, starting all 4.<br/>
        /// Default Value: 1
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
            int? concurrency = default,
            bool? dryRun = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}