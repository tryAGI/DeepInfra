namespace DeepInfra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateChatCompletion()
    {
        // Use the OpenAI SDK to interact with the OpenAI like API
        var client = GetAuthenticatedOpenAiClient();
        var enumerable = client.Chat.CreateChatCompletionAsStreamAsync(
            model: "meta-llama/Meta-Llama-3-8B-Instruct",
            messages: ["What is the capital of the United States?"]);
        
        await foreach (var response in enumerable)
        {
            Console.Write(response.Choices[0].Delta.Content);
        }
    }
}
