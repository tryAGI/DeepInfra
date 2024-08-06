namespace DeepInfra.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DeepInfraApi GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DEEPINFRA_API_KEY") ??
            throw new AssertInconclusiveException("DEEPINFRA_API_KEY environment variable is not found.");

        return new DeepInfraApi(apiKey);
    }
}
