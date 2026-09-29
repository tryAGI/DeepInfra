#nullable enable

namespace DeepInfra
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Openai Responses Not Found
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="xDeepinfraServiceTier">
        /// Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiResponsesNotFound2Async(
            string responseId,
            string? xDeepinfraServiceTier = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openai Responses Not Found
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="xDeepinfraServiceTier">
        /// Per-request service tier (`priority` or `flex`) for clients that cannot set the `service_tier` body field. The body field wins when both are present; unrecognized values ride the default tier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepInfra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepInfra.AutoSDKHttpResponse<string>> OpenaiResponsesNotFound2AsResponseAsync(
            string responseId,
            string? xDeepinfraServiceTier = default,
            global::DeepInfra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}