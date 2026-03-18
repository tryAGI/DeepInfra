using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    private const string DeepInfraEmbeddingModel = "BAAI/bge-en-icl";

    [TestMethod]
    public async Task EmbeddingGenerator_GenerateAsync()
    {
        using var client = GetAuthenticatedOpenAiClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var embeddings = await generator.GenerateAsync(
            ["Hello, world!"],
            new Meai.EmbeddingGenerationOptions { ModelId = DeepInfraEmbeddingModel });

        embeddings.Should().NotBeNull();
        embeddings.Should().HaveCount(1);
        embeddings[0].Vector.Length.Should().BeGreaterThan(0);
        Console.WriteLine($"Embedding dimensions: {embeddings[0].Vector.Length}");
    }

    [TestMethod]
    public async Task EmbeddingGenerator_BatchGenerate()
    {
        using var client = GetAuthenticatedOpenAiClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var embeddings = await generator.GenerateAsync(
            ["First sentence.", "Second sentence.", "Third sentence."],
            new Meai.EmbeddingGenerationOptions { ModelId = DeepInfraEmbeddingModel });

        embeddings.Should().HaveCount(3);
        foreach (var embedding in embeddings)
        {
            embedding.Vector.Length.Should().BeGreaterThan(0);
        }
        Console.WriteLine($"Generated {embeddings.Count} embeddings with {embeddings[0].Vector.Length} dimensions each");
    }
}
