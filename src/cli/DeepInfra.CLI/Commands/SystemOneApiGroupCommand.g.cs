#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class SystemOneApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"system-one", @"System One endpoint commands.");
                         command.Subcommands.Add(SystemOneListModelsCommandApiCommand.Create());
                         command.Subcommands.Add(SystemOneSystemoneCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}