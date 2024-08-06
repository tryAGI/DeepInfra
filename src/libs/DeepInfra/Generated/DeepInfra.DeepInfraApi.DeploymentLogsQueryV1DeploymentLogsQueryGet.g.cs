
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareDeploymentLogsQueryV1DeploymentLogsQueryGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deployId,
            ref string podName,
            ref string from,
            ref string to,
            ref int limit);
        partial void PrepareDeploymentLogsQueryV1DeploymentLogsQueryGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deployId,
            string podName,
            string from,
            string to,
            int limit);
        partial void ProcessDeploymentLogsQueryV1DeploymentLogsQueryGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeploymentLogsQueryV1DeploymentLogsQueryGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Deployment Logs Query<br/>
        /// Query deployment logs.<br/>
        /// * Without timestamps (from/to) returns last `limit` messages (in last month).<br/>
        /// * With `from` only, returns first `limit` messages after `from` (inclusive).<br/>
        /// * With `to` only, returns last `limit` messages before `to` (inclusive).<br/>
        /// * With both `from` and `to`, return the first `limit` messages after `from`, but not later than `to`.<br/>
        /// * `from` and `to` should be no more than a month apart.
        /// </summary>
        /// <param name="deployId">
        /// the deploy id to get the logs from
        /// </param>
        /// <param name="podName">
        /// the pod name to get the logs from
        /// </param>
        /// <param name="from">
        /// start of period, in fractional seconds since unix epoch (inclusive)
        /// </param>
        /// <param name="to">
        /// end of period, in fractional seconds since unix epoch (exclusive)
        /// </param>
        /// <param name="limit">
        /// how many items to return at most (default 100, in [1, 1000])<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeploymentLogQueryOut> DeploymentLogsQueryV1DeploymentLogsQueryGetAsync(
            string deployId,
            string podName,
            string from,
            string to,
            int limit,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeploymentLogsQueryV1DeploymentLogsQueryGetArguments(
                httpClient: _httpClient,
                deployId: ref deployId,
                podName: ref podName,
                from: ref from,
                to: ref to,
                limit: ref limit);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/deployment_logs/query?deploy_id={deployId}&pod_name={podName}&from={from}&to={to}&limit={limit}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeploymentLogsQueryV1DeploymentLogsQueryGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                deployId: deployId,
                podName: podName,
                from: from,
                to: to,
                limit: limit);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeploymentLogsQueryV1DeploymentLogsQueryGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeploymentLogsQueryV1DeploymentLogsQueryGetResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.DeploymentLogQueryOut) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}