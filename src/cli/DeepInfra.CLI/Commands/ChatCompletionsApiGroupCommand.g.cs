#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class ChatCompletionsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"chat-completions", @"Chat Completions endpoint commands.");
                         command.Subcommands.Add(ChatCompletionsAnthropicMessagesCommandApiCommand.Create());
                         command.Subcommands.Add(ChatCompletionsAnthropicMessagesCountTokensCommandApiCommand.Create());
                         command.Subcommands.Add(ChatCompletionsOpenaiChatCompletionsCommandApiCommand.Create());
        return command;
    }
}