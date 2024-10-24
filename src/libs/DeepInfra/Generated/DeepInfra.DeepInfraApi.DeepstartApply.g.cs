
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareDeepstartApplyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? session,
            global::DeepInfra.DeepStartApplicationIn request);
        partial void PrepareDeepstartApplyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? session,
            global::DeepInfra.DeepStartApplicationIn request);
        partial void ProcessDeepstartApplyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeepstartApplyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Deepstart Apply
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeepStartApplicationOut> DeepstartApplyAsync(
            global::DeepInfra.DeepStartApplicationIn request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDeepstartApplyArguments(
                httpClient: HttpClient,
                session: ref session,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/payment/deepstart/application",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDeepstartApplyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDeepstartApplyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessDeepstartApplyResponseContent(
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
                global::DeepInfra.DeepStartApplicationOut.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Deepstart Apply
        /// </summary>
        /// <param name="session"></param>
        /// <param name="id"></param>
        /// <param name="uid"></param>
        /// <param name="company"></param>
        /// <param name="ceo"></param>
        /// <param name="funding"></param>
        /// <param name="foundedOn"></param>
        /// <param name="website"></param>
        /// <param name="createdAt"></param>
        /// <param name="status">
        /// Default Value: pending
        /// </param>
        /// <param name="deal"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeepStartApplicationOut> DeepstartApplyAsync(
            string company,
            string ceo,
            string funding,
            string foundedOn,
            string website,
            string? session = default,
            string? id = default,
            string? uid = default,
            int? createdAt = default,
            string? status = default,
            string? deal = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::DeepInfra.DeepStartApplicationIn
            {
                Id = id,
                Uid = uid,
                Company = company,
                Ceo = ceo,
                Funding = funding,
                FoundedOn = foundedOn,
                Website = website,
                CreatedAt = createdAt,
                Status = status,
                Deal = deal,
            };

            return await DeepstartApplyAsync(
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}