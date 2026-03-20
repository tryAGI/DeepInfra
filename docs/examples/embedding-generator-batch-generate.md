# Embedding Generator Batch Generate



This example assumes `using DeepInfra;` is in scope and `apiKey` contains your DeepInfra API key.

```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var embeddings = await generator.GenerateAsync(
    ["First sentence.", "Second sentence.", "Third sentence."],
    new Meai.EmbeddingGenerationOptions { ModelId = DeepInfraEmbeddingModel });

foreach (var embedding in embeddings)
{
}
Console.WriteLine($"Generated {embeddings.Count} embeddings with {embeddings[0].Vector.Length} dimensions each");
```