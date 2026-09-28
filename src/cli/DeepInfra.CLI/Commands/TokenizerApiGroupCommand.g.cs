#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class TokenizerApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"tokenizer", @"Tokenizer endpoint commands.");
                         command.Subcommands.Add(TokenizerDetokenizeCommandApiCommand.Create());
                         command.Subcommands.Add(TokenizerTokenizeCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}