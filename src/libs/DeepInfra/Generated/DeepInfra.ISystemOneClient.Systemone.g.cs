#nullable enable

namespace DeepInfra
{
    public partial interface ISystemOneClient
    {
        /// <summary>
        /// Systemone
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.SystemOneResponse> SystemoneAsync(

            global::DeepInfra.SystemOneRequest request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Systemone
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<global::DeepInfra.SystemOneResponse>> SystemoneAsResponseAsync(

            global::DeepInfra.SystemOneRequest request,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Systemone
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="xApiKey"></param>
        /// <param name="state"></param>
        /// <param name="model"></param>
        /// <param name="questions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.SystemOneResponse> SystemoneAsync(
            global::DeepInfra.AnyOf<string, object, global::System.Collections.Generic.IList<object>> state,
            string model,
            object questions,
            string? xiApiKey = default,
            string? xApiKey = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}