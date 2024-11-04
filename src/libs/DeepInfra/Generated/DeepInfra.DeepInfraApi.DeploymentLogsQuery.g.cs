
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareDeploymentLogsQueryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deployId,
            ref string? podName,
            ref string? from,
            ref string? to,
            ref int? limit,
            ref string? xiApiKey);
        partial void PrepareDeploymentLogsQueryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deployId,
            string? podName,
            string? from,
            string? to,
            int? limit,
            string? xiApiKey);
        partial void ProcessDeploymentLogsQueryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeploymentLogsQueryResponseContent(
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
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeploymentLogQueryOut> DeploymentLogsQueryAsync(
            string deployId,
            string? podName = default,
            string? from = default,
            string? to = default,
            int? limit = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDeploymentLogsQueryArguments(
                httpClient: HttpClient,
                deployId: ref deployId,
                podName: ref podName,
                from: ref from,
                to: ref to,
                limit: ref limit,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: "/v1/deployment_logs/query",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("deploy_id", deployId) 
                .AddOptionalParameter("pod_name", podName) 
                .AddOptionalParameter("from", from) 
                .AddOptionalParameter("to", to) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDeploymentLogsQueryRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                deployId: deployId,
                podName: podName,
                from: from,
                to: to,
                limit: limit,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDeploymentLogsQueryResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessDeploymentLogsQueryResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::DeepInfra.DeploymentLogQueryOut.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}