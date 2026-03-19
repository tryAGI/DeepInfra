# Usage



This example assumes `using DeepInfra;` is in scope and `apiKey` contains your DeepInfra API key.

```csharp
var client = new DeepInfraClient(apiKey);

Me me = await client.MeAsync();
Console.WriteLine($"{me.ToJson(new JsonSerializerOptions
{
    WriteIndented = true,
})}");
```