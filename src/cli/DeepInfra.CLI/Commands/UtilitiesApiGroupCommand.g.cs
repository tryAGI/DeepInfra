#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class UtilitiesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"utilities", @"Utilities endpoint commands.");
                         command.Subcommands.Add(UtilitiesCliVersionCommandApiCommand.Create());
                         command.Subcommands.Add(UtilitiesSubmitFeedbackCommandApiCommand.Create());
        return command;
    }
}