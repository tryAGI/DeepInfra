#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class TokenizerApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"tokenizer", @"Tokenizer endpoint commands.");
                         command.Subcommands.Add(TokenizerDetokenizeCommandApiCommand.Create());
                         command.Subcommands.Add(TokenizerTokenizeCommandApiCommand.Create());
        return command;
    }
}