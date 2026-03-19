/*
order: 50
title: Chat Client Tool Calling Single Turn
slug: chat-client-tool-calling-single-turn
*/

using Meai = Microsoft.Extensions.AI;

namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_SingleTurn()
    {
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

        response.Should().NotBeNull();
        response.FinishReason.Should().Be(Meai.ChatFinishReason.ToolCalls);

        var functionCall = response.Messages
            .SelectMany(m => m.Contents)
            .OfType<Meai.FunctionCallContent>()
            .FirstOrDefault();

        functionCall.Should().NotBeNull();
        functionCall!.Name.Should().Be("GetWeather");
        Console.WriteLine($"Tool call: {functionCall.Name}({string.Join(", ", functionCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");
    }
}
