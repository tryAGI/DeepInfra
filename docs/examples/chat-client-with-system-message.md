# Chat Client With System Message



This example assumes `using DeepInfra;` is in scope and `apiKey` contains your DeepInfra API key.

```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.System, "You always respond with exactly one word."),
        new Meai.ChatMessage(Meai.ChatRole.User, "What color is the sky?"),
    ],
    new Meai.ChatOptions { ModelId = DeepInfraModel });

var text = response.Messages[0].Text;
Console.WriteLine(text);
```