using tryAGI.OpenAI;

namespace DeepInfra.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DeepInfraClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DEEPINFRA_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            throw new AssertInconclusiveException("DEEPINFRA_API_KEY environment variable is not found.");

        return new DeepInfraClient(apiKey);
    }
    
    private static OpenAiClient GetAuthenticatedOpenAiClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DEEPINFRA_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            throw new AssertInconclusiveException("DEEPINFRA_API_KEY environment variable is not found.");

        return CustomProviders.DeepInfra(apiKey);
    }
}
