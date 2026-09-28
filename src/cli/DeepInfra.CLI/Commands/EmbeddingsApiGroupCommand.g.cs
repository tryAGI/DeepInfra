#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class EmbeddingsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"embeddings", @"Embeddings endpoint commands.");
                         command.Subcommands.Add(EmbeddingsOpenaiEmbeddingsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}