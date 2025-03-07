namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListModels()
    {
        var client = GetAuthenticatedClient();
        var models = await client.ModelsListAsync();
        models.Should().NotBeNull();
        foreach (var model in models)
        {
            Console.WriteLine(model.ModelName);
        }
    }
}
