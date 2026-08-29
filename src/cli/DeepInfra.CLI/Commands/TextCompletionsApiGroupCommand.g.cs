#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class TextCompletionsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"text-completions", @"Text Completions endpoint commands.");
                         command.Subcommands.Add(TextCompletionsOpenaiCompletionsCommandApiCommand.Create());
        return command;
    }
}