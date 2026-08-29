#nullable enable

namespace DeepInfra
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create Sandbox<br/>
        /// Create a new sandbox instance with the given plan and settings. The sandbox starts in CREATING state and transitions to RUNNING asynchronously.
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.SandboxCreateOut> CreateSandboxAsync(

            global::DeepInfra.SandboxCreateIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Sandbox<br/>
        /// Create a new sandbox instance with the given plan and settings. The sandbox starts in CREATING state and transitions to RUNNING asynchronously.
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.SandboxCreateOut>> CreateSandboxAsResponseAsync(

            global::DeepInfra.SandboxCreateIn request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Sandbox<br/>
        /// Create a new sandbox instance with the given plan and settings. The sandbox starts in CREATING state and transitions to RUNNING asynchronously.
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="plan"></param>
        /// <param name="tags"></param>
        /// <param name="timeoutSeconds">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.SandboxCreateOut> CreateSandboxAsync(
            string? xiApiKey = default,
            string? xApiKey = default,
            string? plan = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            int? timeoutSeconds = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}