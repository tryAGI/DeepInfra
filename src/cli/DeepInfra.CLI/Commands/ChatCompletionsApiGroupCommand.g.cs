#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ChatCompletionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"chat-completions", @"Chat Completions endpoint commands.");
                         command.Subcommands.Add(ChatCompletionsAnthropicMessagesCommandApiCommand.Create());
                         command.Subcommands.Add(ChatCompletionsAnthropicMessagesCountTokensCommandApiCommand.Create());
                         command.Subcommands.Add(ChatCompletionsOpenaiChatCompletionsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}