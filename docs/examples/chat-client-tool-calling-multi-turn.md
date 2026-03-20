# Chat Client Tool Calling Multi Turn



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

var chatOptions = new Meai.ChatOptions
{
    ModelId = DeepInfraModel,
    Tools = [tool],
};

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "What's the weather in Paris? Respond with the temperature only."),
};

// First turn — get tool call
var response = await chatClient.GetResponseAsync(
    (IEnumerable<Meai.ChatMessage>)messages, chatOptions);

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<Meai.FunctionCallContent>()
    .First();

// Execute tool and add result
var toolResult = await tool.InvokeAsync(
    functionCall.Arguments is { } args
        ? new Meai.AIFunctionArguments(args)
        : null);
messages.AddRange(response.Messages);
messages.Add(new Meai.ChatMessage(Meai.ChatRole.Tool,
    new Meai.AIContent[]
    {
        new Meai.FunctionResultContent(functionCall.CallId, toolResult),
    }));

// Second turn — get final response
var finalResponse = await chatClient.GetResponseAsync(
    (IEnumerable<Meai.ChatMessage>)messages, chatOptions);

var text = finalResponse.Messages[0].Text;
Console.WriteLine($"Final response: {text}");
```