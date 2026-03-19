# ChatClient.ReturnsUsage



This example assumes `using DeepInfra;` is in scope and `apiKey` contains your DeepInfra API key.

```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "Say 'hi'.")],
    new Meai.ChatOptions { ModelId = DeepInfraModel });

Console.WriteLine($"Input: {response.Usage.InputTokenCount}, Output: {response.Usage.OutputTokenCount}, Total: {response.Usage.TotalTokenCount}");
```