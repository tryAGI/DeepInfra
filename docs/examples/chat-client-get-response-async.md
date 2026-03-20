# Chat Client Get Response Async



This example assumes `using DeepInfra;` is in scope and `apiKey` contains your DeepInfra API key.

```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "Say hello in exactly 3 words.")],
    new Meai.ChatOptions { ModelId = DeepInfraModel });

var text = response.Messages[0].Text;
Console.WriteLine(text);
```