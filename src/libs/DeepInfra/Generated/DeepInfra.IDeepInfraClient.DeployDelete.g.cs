#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Deploy Delete
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.DeployDelete> DeployDeleteAsync(
            string deployId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}