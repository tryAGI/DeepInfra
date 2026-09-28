#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class InferenceApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"inference", @"Inference endpoint commands.");
                         command.Subcommands.Add(InferenceInferenceDeployCommandApiCommand.Create());
                         command.Subcommands.Add(InferenceInferenceModelCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}