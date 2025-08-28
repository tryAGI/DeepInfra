#nullable enable

namespace DeepInfra
{
    public partial interface IDeepInfraClient
    {
        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiFilesAsync(
            global::DeepInfra.BodyOpenaiFilesV1FilesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Files
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="purpose"></param>
        /// <param name="file"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiFilesAsync(
            string purpose,
            global::System.Collections.Generic.IList<byte[]> file,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}