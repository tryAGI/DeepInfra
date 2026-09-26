#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class SystemOneApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"system-one", @"System One endpoint commands.");
                         command.Subcommands.Add(SystemOneListModelsCommandApiCommand.Create());
                         command.Subcommands.Add(SystemOneSystemoneCommandApiCommand.Create());
        return command;
    }
}