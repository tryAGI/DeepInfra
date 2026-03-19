# ListModels



This example assumes `using DeepInfra;` is in scope and `apiKey` contains your DeepInfra API key.

```csharp
var client = new DeepInfraClient(apiKey);
var models = await client.ModelsListAsync();
foreach (var model in models)
{
    Console.WriteLine(model.ModelName);
}
```