#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ResponsesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"responses", @"Responses endpoint commands.");
                         command.Subcommands.Add(ResponsesOpenaiResponsesCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesOpenaiResponsesNotFoundCommandApiCommand.Create());
                         command.Subcommands.Add(ResponsesOpenaiResponsesNotFound2CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}