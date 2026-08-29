#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class DedicatedModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"dedicated-models", @"Dedicated Models endpoint commands.");
                         command.Subcommands.Add(DedicatedModelsDeployArgsHistoryCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployArgsRestoreCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployCreateCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployCreateHfCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployCreateLlmCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployDetailedStatsCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployGpuAvailabilityCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployList2CommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployLlmPresetsCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployLlmStandardArgsCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployLlmSuggestNameCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployRebalanceCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployRebalanceCancelCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployRebalanceStatusCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployStartCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployStatsCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployStatusCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployStopCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeployUpdateCommandApiCommand.Create());
                         command.Subcommands.Add(DedicatedModelsDeploymentStatsCommandApiCommand.Create());
        return command;
    }
}