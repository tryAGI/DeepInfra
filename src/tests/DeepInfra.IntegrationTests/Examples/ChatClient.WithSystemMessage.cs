/*
order: 60
title: Chat Client With System Message
slug: chat-client-with-system-message
*/

using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_WithSystemMessage()
    {
        using var client = GetAuthenticatedOpenAiClient();
        Meai.IChatClient chatClient = client;

        var response = await chatClient.GetResponseAsync(
            [
                new Meai.ChatMessage(Meai.ChatRole.System, "You always respond with exactly one word."),
                new Meai.ChatMessage(Meai.ChatRole.User, "What color is the sky?"),
            ],
            new Meai.ChatOptions { ModelId = DeepInfraModel });

        response.Should().NotBeNull();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine(text);
    }
}
