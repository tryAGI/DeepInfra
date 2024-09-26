namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Usage()
    {
        var api = GetAuthenticatedClient();
        
        UsageOut usageOut = await api.UsageAsync("2024.01");
        foreach (var usage in usageOut.Months)
        {
            Console.WriteLine($"Total Cost: {usage.TotalCost}");
        }
    }
}
