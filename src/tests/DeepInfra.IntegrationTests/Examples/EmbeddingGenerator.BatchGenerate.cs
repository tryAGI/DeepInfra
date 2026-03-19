/*
order: 80
title: Embedding Generator Batch Generate
slug: embedding-generator-batch-generate
*/

using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
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
