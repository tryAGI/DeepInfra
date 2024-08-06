# DeepInfra

[![Nuget package](https://img.shields.io/nuget/vpre/DeepInfra)](https://www.nuget.org/packages/DeepInfra/)
[![dotnet](https://github.com/tryAGI/DeepInfra/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/DeepInfra/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/DeepInfra)](https://github.com/tryAGI/DeepInfra/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official DeepInfra OpenAPI specification](https://api.deepinfra.com/openapi.json) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- Contains a supported list of constants such as current prices, models, and other
- Source generator to define functions natively through C# interfaces
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Support all DeepInfra API endpoints including Object Detection, Token Classification, Image Classification, Fill Mask and more.

## Usage
```csharp
using var api = new DeepInfraApi("API_KEY");
string response = await api.Chat.CreateChatCompletionAsync(
    messages: ["Generate five random words."],
    model: CreateChatCompletionRequestModel.Gpt4oMini);
Console.WriteLine(response); // "apple, banana, cherry, date, elderberry"

var enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
    messages: ["Generate five random words."],
    model: CreateChatCompletionRequestModel.Gpt4oMini);

await foreach (string response in enumerable)
{
    Console.WriteLine(response);
}
```

## Support

Priority place for bugs: https://github.com/tryAGI/DeepInfra/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/DeepInfra/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  