#nullable enable

namespace DeepInfra
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Write File<br/>
        /// Write the raw request body (application/octet-stream, max 100 MiB) to an absolute path inside the sandbox.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="path"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> WriteFileAsync(
            string sandboxId,
            string path,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Write File<br/>
        /// Write the raw request body (application/octet-stream, max 100 MiB) to an absolute path inside the sandbox.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="path"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<string>> WriteFileAsResponseAsync(
            string sandboxId,
            string path,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}