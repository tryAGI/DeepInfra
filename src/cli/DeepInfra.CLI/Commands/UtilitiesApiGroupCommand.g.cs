#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class UtilitiesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"utilities", @"Utilities endpoint commands.");
                         command.Subcommands.Add(UtilitiesCliVersionCommandApiCommand.Create());
                         command.Subcommands.Add(UtilitiesSubmitFeedbackCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}