/*
order: 90
title: Embedding Generator Generate Async
slug: embedding-generator-generate-async
*/

using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
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
}
