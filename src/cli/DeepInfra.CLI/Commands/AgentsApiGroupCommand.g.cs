#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class AgentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"agents", @"Agents endpoint commands.");
                         command.Subcommands.Add(AgentsCreateBackupCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsCreateDashboardLaunchTokenCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsCreateInstanceCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsDeleteInstanceCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetCatalogCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsGetInstanceCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListBackupsCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsListInstancesCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRenameInstanceCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsRestoreBackupCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsStartInstanceCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsStopInstanceCommandApiCommand.Create());
                         command.Subcommands.Add(AgentsUpdateInstanceVersionCommandApiCommand.Create());
        return command;
    }
}