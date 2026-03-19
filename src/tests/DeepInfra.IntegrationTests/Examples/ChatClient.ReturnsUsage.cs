/*
order: 30
title: Chat Client Returns Usage
slug: chat-client-returns-usage
*/

using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ReturnsUsage()
    {
        using var client = GetAuthenticatedOpenAiClient();
        Meai.IChatClient chatClient = client;

        var response = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "Say 'hi'.")],
            new Meai.ChatOptions { ModelId = DeepInfraModel });

        response.Usage.Should().NotBeNull();
        response.Usage!.InputTokenCount.Should().BeGreaterThan(0);
        response.Usage.OutputTokenCount.Should().BeGreaterThan(0);
        Console.WriteLine($"Input: {response.Usage.InputTokenCount}, Output: {response.Usage.OutputTokenCount}, Total: {response.Usage.TotalTokenCount}");
    }
}
