#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AccountApiGroupCommand.Create());
                         command.Subcommands.Add(AgentsApiGroupCommand.Create());
                         command.Subcommands.Add(AudioApiGroupCommand.Create());
                         command.Subcommands.Add(AuthenticationApiGroupCommand.Create());
                         command.Subcommands.Add(BillingApiGroupCommand.Create());
                         command.Subcommands.Add(ChatCompletionsApiGroupCommand.Create());
                         command.Subcommands.Add(DedicatedModelsApiGroupCommand.Create());
                         command.Subcommands.Add(EmbeddingsApiGroupCommand.Create());
                         command.Subcommands.Add(FilesBatchesApiGroupCommand.Create());
                         command.Subcommands.Add(GPURentalsApiGroupCommand.Create());
                         command.Subcommands.Add(ImageGenerationApiGroupCommand.Create());
                         command.Subcommands.Add(InferenceApiGroupCommand.Create());
                         command.Subcommands.Add(LogsMetricsApiGroupCommand.Create());
                         command.Subcommands.Add(LoRAAdaptersApiGroupCommand.Create());
                         command.Subcommands.Add(ModelsApiGroupCommand.Create());
                         command.Subcommands.Add(SandboxesApiGroupCommand.Create());
                         command.Subcommands.Add(TextCompletionsApiGroupCommand.Create());
                         command.Subcommands.Add(TextToSpeechApiGroupCommand.Create());
                         command.Subcommands.Add(TokenizerApiGroupCommand.Create());
                         command.Subcommands.Add(UtilitiesApiGroupCommand.Create());
                         command.Subcommands.Add(VideosApiGroupCommand.Create());
        return command;
    }
}