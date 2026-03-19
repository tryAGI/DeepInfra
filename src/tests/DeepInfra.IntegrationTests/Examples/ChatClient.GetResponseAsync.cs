/*
order: 10
title: Chat Client Get Response Async
slug: chat-client-get-response-async
*/

using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_GetResponseAsync()
    {
        using var client = GetAuthenticatedOpenAiClient();
        Meai.IChatClient chatClient = client;

        var response = await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "Say hello in exactly 3 words.")],
            new Meai.ChatOptions { ModelId = DeepInfraModel });

        response.Should().NotBeNull();
        response.Messages.Should().NotBeEmpty();
        var text = response.Messages[0].Text;
        text.Should().NotBeNullOrWhiteSpace();
        Console.WriteLine(text);
    }
}
