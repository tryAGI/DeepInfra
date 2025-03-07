#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Cli Version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CliVersionAsync(
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}