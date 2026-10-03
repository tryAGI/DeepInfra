#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class DecisionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"decisions", @"Decisions endpoint commands.");
                         command.Subcommands.Add(DecisionsListModelsCommandApiCommand.Create());
                         command.Subcommands.Add(DecisionsSystemoneCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}