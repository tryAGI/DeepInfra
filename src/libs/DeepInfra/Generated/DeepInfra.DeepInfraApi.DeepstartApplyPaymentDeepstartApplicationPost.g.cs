
#nullable enable

namespace DeepInfra
{
    public partial class DeepInfraApi
    {
        partial void PrepareDeepstartApplyPaymentDeepstartApplicationPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? session,
            global::DeepInfra.DeepStartApplicationIn request);
        partial void PrepareDeepstartApplyPaymentDeepstartApplicationPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? session,
            global::DeepInfra.DeepStartApplicationIn request);
        partial void ProcessDeepstartApplyPaymentDeepstartApplicationPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeepstartApplyPaymentDeepstartApplicationPostResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeepStartApplicationOut> DeepstartApplyPaymentDeepstartApplicationPostAsync(
            string? session,
            global::DeepInfra.DeepStartApplicationIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDeepstartApplyPaymentDeepstartApplicationPostArguments(
                httpClient: _httpClient,
                session: ref session,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/payment/deepstart/application", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, global::DeepInfra.SourceGenerationContext.Default.DeepStartApplicationIn),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeepstartApplyPaymentDeepstartApplicationPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                session: session,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeepstartApplyPaymentDeepstartApplicationPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeepstartApplyPaymentDeepstartApplicationPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::DeepInfra.SourceGenerationContext.Default.DeepStartApplicationOut) ??
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
        public async global::System.Threading.Tasks.Task<global::DeepInfra.DeepStartApplicationOut> DeepstartApplyPaymentDeepstartApplicationPostAsync(
            string company,
            string ceo,
            string funding,
            string foundedOn,
            string website,
            string? session = default,
            string? id = default,
            string? uid = default,
            int createdAt = default,
            string? status = "pending",
            string? deal = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::DeepInfra.DeepStartApplicationIn
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

            return await DeepstartApplyPaymentDeepstartApplicationPostAsync(
                session: session,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}