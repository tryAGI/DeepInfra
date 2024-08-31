
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareLogsQueryV1LogsQueryGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deployId,
            ref string? from,
            ref string? to,
            ref int limit);
        partial void PrepareLogsQueryV1LogsQueryGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deployId,
            string? from,
            string? to,
            int limit);
        partial void ProcessLogsQueryV1LogsQueryGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessLogsQueryV1LogsQueryGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Logs Query<br/>
        /// Query inference logs.<br/>
        /// * Without timestamps (from/to) returns last `limit` messages (in last month).<br/>
        /// * With `from` only, returns first `limit` messages after `from` (inclusive).<br/>
        /// * With `to` only, returns last `limit` messages before `to` (inclusive).<br/>
        /// * With both `from` and `to`, return the first `limit` messages after `from`, but not later than `to`.<br/>
        /// * `from` and `to` should be no more than a month apart.
        /// </summary>
        /// <param name="deployId">
        /// the deploy id to get the logs from
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
        public async global::System.Threading.Tasks.Task<global::DeepInfra.LogQueryOut> LogsQueryV1LogsQueryGetAsync(
            string deployId,
            string? from = default,
            string? to = default,
            int limit = 100,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareLogsQueryV1LogsQueryGetArguments(
                httpClient: _httpClient,
                deployId: ref deployId,
                from: ref from,
                to: ref to,
                limit: ref limit);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/logs/query?deploy_id={deployId}&from={from}&to={to}&limit={limit}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareLogsQueryV1LogsQueryGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                deployId: deployId,
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
            ProcessLogsQueryV1LogsQueryGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessLogsQueryV1LogsQueryGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.LogQueryOut) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}