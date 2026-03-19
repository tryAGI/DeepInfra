/*
order: 70
title: Create Chat Completion
slug: create-chat-completion
*/

using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateChatCompletion()
    {
        // Use the OpenAI SDK via CustomProviders.DeepInfra() with MEAI interface
        using var client = GetAuthenticatedOpenAiClient();
        Meai.IChatClient chatClient = client;

        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "What is the capital of the United States?")],
            new Meai.ChatOptions { ModelId = DeepInfraModel }))
        {
            var text = string.Concat(update.Contents.OfType<Meai.TextContent>().Select(c => c.Text));
            Console.Write(text);
        }
    }
}
