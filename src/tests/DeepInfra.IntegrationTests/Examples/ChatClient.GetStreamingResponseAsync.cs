/*
order: 20
title: Chat Client Get Streaming Response Async
slug: chat-client-get-streaming-response-async
*/

using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_GetStreamingResponseAsync()
    {
        using var client = GetAuthenticatedOpenAiClient();
        Meai.IChatClient chatClient = client;

        var updates = new List<Meai.ChatResponseUpdate>();
        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "Count from 1 to 5.")],
            new Meai.ChatOptions { ModelId = DeepInfraModel }))
        {
            updates.Add(update);
            var text = string.Concat(update.Contents.OfType<Meai.TextContent>().Select(c => c.Text));
            if (!string.IsNullOrEmpty(text))
            {
                Console.Write(text);
            }
        }
        Console.WriteLine();

        updates.Should().NotBeEmpty();
    }
}
