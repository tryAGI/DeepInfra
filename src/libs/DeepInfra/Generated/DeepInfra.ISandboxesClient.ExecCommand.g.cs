#nullable enable

namespace DeepInfra
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Exec Command<br/>
        /// Run a command in the sandbox. Streams NDJSON lines (application/x-ndjson): {"stdout": ...}/{"stderr": ...} chunks followed by exactly one terminal {"returncode": N} or {"error": msg} line.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExecCommandAsync(
            string sandboxId,

            global::DeepInfra.SandboxExecIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exec Command<br/>
        /// Run a command in the sandbox. Streams NDJSON lines (application/x-ndjson): {"stdout": ...}/{"stderr": ...} chunks followed by exactly one terminal {"returncode": N} or {"error": msg} line.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<string>> ExecCommandAsResponseAsync(
            string sandboxId,

            global::DeepInfra.SandboxExecIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exec Command<br/>
        /// Run a command in the sandbox. Streams NDJSON lines (application/x-ndjson): {"stdout": ...}/{"stderr": ...} chunks followed by exactly one terminal {"returncode": N} or {"error": msg} line.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="command"></param>
        /// <param name="timeoutSeconds">
        /// Seconds to allow the command to run before it's killed. 0 uses the server default (60s). Capped at 1800s (30 minutes).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExecCommandAsync(
            string sandboxId,
            global::System.Collections.Generic.IList<string> command,
            string? xiApiKey = default,
            string? xApiKey = default,
            int? timeoutSeconds = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}