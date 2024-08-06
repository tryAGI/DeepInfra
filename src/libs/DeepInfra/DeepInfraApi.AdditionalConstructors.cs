using System.Net.Http;

namespace DeepInfra;

public partial class DeepInfraApi
{
    /// <inheritdoc cref="DeepInfraApi(HttpClient?, Uri?)"/>
    public DeepInfraApi(
        string apiKey, 
        HttpClient? httpClient = null,
        Uri? baseUri = null) : this(httpClient, baseUri ?? new Uri("https://api.deepinfra.com/v1/"))
    {
        //AuthorizeUsingBearer(apiKey);
        _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
            scheme: "Bearer",
            parameter: apiKey);
    }
}