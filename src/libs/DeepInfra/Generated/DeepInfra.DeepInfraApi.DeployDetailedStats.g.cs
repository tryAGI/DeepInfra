
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareDeployDetailedStatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deployId,
            ref string from,
            ref string? to);
        partial void PrepareDeployDetailedStatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deployId,
            string from,
            string? to);
        partial void ProcessDeployDetailedStatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeployDetailedStatsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Deploy Detailed Stats
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="from">
        /// start of period, unix ts or 'now-5h', supported units s, m, h, d, w
        /// </param>
        /// <param name="to">
        /// end of period, unix ts or now-relative, check from, defaults to now<br/>
        /// Default Value: now
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DetailedDeploymentStatsOut> DeployDetailedStatsAsync(
            string deployId,
            string from,
            string? to = "now",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeployDetailedStatsArguments(
                httpClient: _httpClient,
                deployId: ref deployId,
                from: ref from,
                to: ref to);

            var __pathBuilder = new PathBuilder(
                path: $"/deploy/{deployId}/stats2",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("from", from) 
                .AddOptionalParameter("to", to) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeployDetailedStatsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                deployId: deployId,
                from: from,
                to: to);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeployDetailedStatsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeployDetailedStatsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::DeepInfra.DetailedDeploymentStatsOut), JsonSerializerContext) as global::DeepInfra.DetailedDeploymentStatsOut ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}