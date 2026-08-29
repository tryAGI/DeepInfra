#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class SandboxesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"sandboxes", @"Sandboxes endpoint commands.");
                         command.Subcommands.Add(SandboxesCreateSandboxCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesDeleteSandboxCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesExecCommandCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesGetSandboxCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesListSandboxPlansCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesListSandboxesCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesReadFileCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesStartSandboxCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesStopSandboxCommandApiCommand.Create());
                         command.Subcommands.Add(SandboxesWriteFileCommandApiCommand.Create());
        return command;
    }
}