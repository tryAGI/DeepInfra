
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareDeployUpdateDeployDeployIdPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string deployId,
            global::DeepInfra.DeployLLMUpdateIn request);
        partial void PrepareDeployUpdateDeployDeployIdPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string deployId,
            global::DeepInfra.DeployLLMUpdateIn request);
        partial void ProcessDeployUpdateDeployDeployIdPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeployUpdateDeployDeployIdPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Deploy Update
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeployStatusOut> DeployUpdateDeployDeployIdPutAsync(
            string deployId,
            global::DeepInfra.DeployLLMUpdateIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDeployUpdateDeployDeployIdPutArguments(
                httpClient: _httpClient,
                deployId: ref deployId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/deploy/{deployId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.DeployLLMUpdateIn),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeployUpdateDeployDeployIdPutRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                deployId: deployId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeployUpdateDeployDeployIdPutResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeployUpdateDeployDeployIdPutResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.DeployStatusOut) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Deploy Update
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="settings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeployStatusOut> DeployUpdateDeployDeployIdPutAsync(
            string deployId,
            global::DeepInfra.ScaleSettings settings,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.DeployLLMUpdateIn
            {
                Settings = settings,
            };

            return await DeployUpdateDeployDeployIdPutAsync(
                deployId: deployId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}