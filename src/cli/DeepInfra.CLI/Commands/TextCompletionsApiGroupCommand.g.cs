#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class TextCompletionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"text-completions", @"Text Completions endpoint commands.");
                         command.Subcommands.Add(TextCompletionsOpenaiCompletionsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}