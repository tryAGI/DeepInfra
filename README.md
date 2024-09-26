# [DeepInfra](https://deepinfra.com/docs/deep_infra_api)

[![Nuget package](https://img.shields.io/nuget/vpre/DeepInfra)](https://www.nuget.org/packages/DeepInfra/)
[![dotnet](https://github.com/tryAGI/DeepInfra/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/DeepInfra/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/DeepInfra)](https://github.com/tryAGI/DeepInfra/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official DeepInfra OpenAPI specification](https://api.deepinfra.com/openapi.json) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Support all DeepInfra API endpoints including Object Detection, Token Classification, Image Classification, Fill Mask and more.

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

## Support

Priority place for bugs: https://github.com/tryAGI/DeepInfra/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/DeepInfra/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).