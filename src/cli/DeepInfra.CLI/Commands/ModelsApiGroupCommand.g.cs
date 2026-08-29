#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class ModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"models", @"Models endpoint commands.");
                         command.Subcommands.Add(ModelsGetHardwareCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelFamiliesNamesCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelFamilyCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelMetaUpdateCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelPublicityCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelSchemaCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelVersionsCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelsDeploymentListCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelsFeaturedCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelsInfoCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelsListCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsModelsLoraListCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsOpenaiModelsCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsOpenrouterModelsCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsPrivateModelsListCommandApiCommand.Create());
        return command;
    }
}