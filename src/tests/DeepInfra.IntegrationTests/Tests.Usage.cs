using System.Text.Json;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Usage()
    {
        var client = GetAuthenticatedClient();
        
        Me me = await client.MeAsync();
        Console.WriteLine($"{me.ToJson(new JsonSerializerOptions
        {
            WriteIndented = true,
        })}");
    }
}
