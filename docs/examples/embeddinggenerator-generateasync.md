# EmbeddingGenerator.GenerateAsync



This example assumes `using DeepInfra;` is in scope and `apiKey` contains your DeepInfra API key.

```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new Meai.EmbeddingGenerationOptions { ModelId = DeepInfraEmbeddingModel });

Console.WriteLine($"Embedding dimensions: {embeddings[0].Vector.Length}");
```