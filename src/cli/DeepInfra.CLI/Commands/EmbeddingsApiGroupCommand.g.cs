#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class EmbeddingsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"embeddings", @"Embeddings endpoint commands.");
                         command.Subcommands.Add(EmbeddingsOpenaiEmbeddingsCommandApiCommand.Create());
        return command;
    }
}