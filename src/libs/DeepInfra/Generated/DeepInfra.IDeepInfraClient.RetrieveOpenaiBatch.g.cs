#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Retrieve Openai Batch
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveOpenaiBatchAsync(
            string batchId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}