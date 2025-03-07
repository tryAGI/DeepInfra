#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Deploy List
        /// </summary>
        /// <param name="status">
        /// A list of statuses that should be returned, separated by comma. Allowed values in the list are: initializing,deploying,running,failed,deleted
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepInfra.DeploymentOut>> DeployList2Async(
            string? status = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}