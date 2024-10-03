using OpenAI;

namespace DeepInfra.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DeepInfraApi GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DEEPINFRA_API_KEY") ??
            throw new AssertInconclusiveException("DEEPINFRA_API_KEY environment variable is not found.");

        return new DeepInfraApi(apiKey);
    }
    
    private static OpenAiApi GetAuthenticatedOpenAiClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DEEPINFRA_API_KEY") ??
            throw new AssertInconclusiveException("DEEPINFRA_API_KEY environment variable is not found.");

        return CustomProviders.DeepInfra(apiKey);
    }
}