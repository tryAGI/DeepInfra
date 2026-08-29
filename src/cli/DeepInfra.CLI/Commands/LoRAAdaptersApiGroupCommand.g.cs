#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class LoRAAdaptersApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"lo-ra-adapters", @"LoRA Adapters endpoint commands.");
                         command.Subcommands.Add(LoRAAdaptersCreateLoraCommandApiCommand.Create());
                         command.Subcommands.Add(LoRAAdaptersDeleteLoraCommandApiCommand.Create());
                         command.Subcommands.Add(LoRAAdaptersDeleteLoraModelCommandApiCommand.Create());
                         command.Subcommands.Add(LoRAAdaptersGetLoraCommandApiCommand.Create());
                         command.Subcommands.Add(LoRAAdaptersGetLoraStatusCommandApiCommand.Create());
                         command.Subcommands.Add(LoRAAdaptersGetModelLorasCommandApiCommand.Create());
                         command.Subcommands.Add(LoRAAdaptersGetUserLorasCommandApiCommand.Create());
                         command.Subcommands.Add(LoRAAdaptersUpdateLoraCommandApiCommand.Create());
                         command.Subcommands.Add(LoRAAdaptersUploadLoraModelCommandApiCommand.Create());
        return command;
    }
}