using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    private const string DeepInfraModel = "Qwen/Qwen2.5-72B-Instruct";

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
