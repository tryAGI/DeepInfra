# Create Chat Completion



This example assumes `using DeepInfra;` is in scope and `apiKey` contains your DeepInfra API key.

```csharp
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
```