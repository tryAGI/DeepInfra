#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class FilesBatchesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"files-batches", @"Files & Batches endpoint commands.");
                         command.Subcommands.Add(FilesBatchesCancelOpenaiBatchCommandApiCommand.Create());
                         command.Subcommands.Add(FilesBatchesCreateOpenaiBatchCommandApiCommand.Create());
                         command.Subcommands.Add(FilesBatchesDeleteFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesBatchesGetFileCommandApiCommand.Create());
                         command.Subcommands.Add(FilesBatchesGetFileContentCommandApiCommand.Create());
                         command.Subcommands.Add(FilesBatchesListFilesCommandApiCommand.Create());
                         command.Subcommands.Add(FilesBatchesOpenaiFilesCommandApiCommand.Create());
                         command.Subcommands.Add(FilesBatchesRetrieveOpenaiBatchCommandApiCommand.Create());
                         command.Subcommands.Add(FilesBatchesRetrieveOpenaiBatchesCommandApiCommand.Create());
        return command;
    }
}