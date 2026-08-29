#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class InferenceApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"inference", @"Inference endpoint commands.");
                         command.Subcommands.Add(InferenceInferenceDeployCommandApiCommand.Create());
                         command.Subcommands.Add(InferenceInferenceModelCommandApiCommand.Create());
        return command;
    }
}