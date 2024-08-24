
#nullable enable

namespace DeepInfra
{
    public sealed partial class DeepInfraApi
    {
        /// <inheritdoc cref="DeepInfraApi(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public DeepInfraApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            AuthorizeUsingBearer(apiKey);
        }
    }
}