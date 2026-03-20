# Chat Client Tool Calling Single Turn



This example assumes `using DeepInfra;` is in scope and `apiKey` contains your DeepInfra API key.

```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IChatClient chatClient = client;

var tool = Meai.AIFunctionFactory.Create(
    (string city) => city switch
    {
        "Paris" => "22°C, sunny",
        "London" => "15°C, cloudy",
        _ => "Unknown",
    },
    name: "GetWeather",
    description: "Gets the current weather for a city");

var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "What's the weather in Paris?")],
    new Meai.ChatOptions
    {
        ModelId = DeepInfraModel,
        Tools = [tool],
    });

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<Meai.FunctionCallContent>()
    .FirstOrDefault();

Console.WriteLine($"Tool call: {functionCall.Name}({string.Join(", ", functionCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");
```