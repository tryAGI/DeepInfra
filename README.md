# [DeepInfra](https://deepinfra.com/docs/deep_infra_api)

[![Nuget package](https://img.shields.io/nuget/vpre/DeepInfra)](https://www.nuget.org/packages/DeepInfra/)
[![dotnet](https://github.com/tryAGI/DeepInfra/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/DeepInfra/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/DeepInfra)](https://github.com/tryAGI/DeepInfra/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official DeepInfra OpenAPI specification](https://api.deepinfra.com/openapi.json) using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Support all DeepInfra API endpoints including Object Detection, Token Classification, Image Classification, Fill Mask and more.
- Microsoft.Extensions.AI `IChatClient` and `IEmbeddingGenerator` support via `tryAGI.OpenAI` CustomProviders

## Usage

To interact with the OpenAI like API, you need to use `tryAGI.OpenAI` library:
```
<PackageReference Include="tryAGI.OpenAI" Version="3.7.0" />
```
```csharp
using OpenAI;

using var client = CustomProviders.DeepInfra(apiKey);
var enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
    model: "meta-llama/Meta-Llama-3-8B-Instruct",
    messages: ["What is the capital of the United States?"]);

await foreach (var response in enumerable)
{
    Console.Write(response.Choices[0].Delta.Content);
}
```

### Microsoft.Extensions.AI (MEAI) Support

DeepInfra provides an OpenAI-compatible API. For `IChatClient` and `IEmbeddingGenerator` support via [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI.Abstractions), use the `tryAGI.OpenAI` package:
```
dotnet add package tryAGI.OpenAI
```
```csharp
using OpenAI;
using Microsoft.Extensions.AI;

using var client = CustomProviders.DeepInfra(apiKey);

// IChatClient
IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync(
    "Hello!",
    new ChatOptions { ModelId = "Qwen/Qwen2.5-72B-Instruct" });

// IEmbeddingGenerator
IEmbeddingGenerator<string, Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions { ModelId = "BAAI/bge-en-icl" });
```

<!-- EXAMPLES:START -->
### Chat Client Get Response Async
```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "Say hello in exactly 3 words.")],
    new Meai.ChatOptions { ModelId = DeepInfraModel });

var text = response.Messages[0].Text;
Console.WriteLine(text);
```

### Chat Client Get Streaming Response Async
```csharp
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
```

### Chat Client Returns Usage
```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "Say 'hi'.")],
    new Meai.ChatOptions { ModelId = DeepInfraModel });

Console.WriteLine($"Input: {response.Usage.InputTokenCount}, Output: {response.Usage.OutputTokenCount}, Total: {response.Usage.TotalTokenCount}");
```

### Chat Client Tool Calling Multi Turn
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

### Chat Client Tool Calling Single Turn
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

### Chat Client With System Message
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

### Create Chat Completion
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

### Embedding Generator Batch Generate
```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var embeddings = await generator.GenerateAsync(
    ["First sentence.", "Second sentence.", "Third sentence."],
    new Meai.EmbeddingGenerationOptions { ModelId = DeepInfraEmbeddingModel });

foreach (var embedding in embeddings)
{
}
Console.WriteLine($"Generated {embeddings.Count} embeddings with {embeddings[0].Vector.Length} dimensions each");
```

### Embedding Generator Generate Async
```csharp
using var client = GetAuthenticatedOpenAiClient();
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new Meai.EmbeddingGenerationOptions { ModelId = DeepInfraEmbeddingModel });

Console.WriteLine($"Embedding dimensions: {embeddings[0].Vector.Length}");
```

### List Models
```csharp
var client = new DeepInfraClient(apiKey);
var models = await client.ModelsListAsync();
foreach (var model in models)
{
    Console.WriteLine(model.ModelName);
}
```

### Usage
```csharp
var client = new DeepInfraClient(apiKey);

Me me = await client.MeAsync();
Console.WriteLine($"{me.ToJson(new JsonSerializerOptions
{
    WriteIndented = true,
})}");
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/DeepInfra/issues
Priority place for ideas and general questions: https://github.com/tryAGI/DeepInfra/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
