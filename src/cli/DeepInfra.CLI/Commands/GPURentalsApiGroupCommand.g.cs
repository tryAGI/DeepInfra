#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class GPURentalsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"gpu-rentals", @"GPU Rentals endpoint commands.");
                         command.Subcommands.Add(GpuRentalsContainerRentalsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(GpuRentalsContainerRentalsGetCommandApiCommand.Create());
                         command.Subcommands.Add(GpuRentalsContainerRentalsGetParamsCommandApiCommand.Create());
                         command.Subcommands.Add(GpuRentalsContainerRentalsListCommandApiCommand.Create());
                         command.Subcommands.Add(GpuRentalsContainerRentalsStartCommandApiCommand.Create());
                         command.Subcommands.Add(GpuRentalsContainerRentalsUpdateCommandApiCommand.Create());
                         command.Subcommands.Add(GpuRentalsRentGpuAvailabilityCommandApiCommand.Create());
        return command;
    }
}