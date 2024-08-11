
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareDeployStatsDeployDeployIdStatsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deployId,
            ref string from,
            ref string? to);
        partial void PrepareDeployStatsDeployDeployIdStatsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deployId,
            string from,
            string? to);
        partial void ProcessDeployStatsDeployDeployIdStatsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeployStatsDeployDeployIdStatsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Deploy Stats
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="from">
        /// start of period, unix ts or 'now-5h', supported units s(ec), m(min), h(our), d(ay), w(eek), M(onth)
        /// </param>
        /// <param name="to">
        /// end of period, unix ts or now-relative, check from, defaults to now<br/>
        /// Default Value: now
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeploymentStatsOut> DeployStatsDeployDeployIdStatsGetAsync(
            string deployId,
            string from,
            string? to,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeployStatsDeployDeployIdStatsGetArguments(
                httpClient: _httpClient,
                deployId: ref deployId,
                from: ref from,
                to: ref to);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/deploy/{deployId}/stats?from={from}&to={to}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeployStatsDeployDeployIdStatsGetRequest(
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
            ProcessDeployStatsDeployDeployIdStatsGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeployStatsDeployDeployIdStatsGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.DeploymentStatsOut) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}