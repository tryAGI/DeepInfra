#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class ImageGenerationApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"image-generation", @"Image Generation endpoint commands.");
                         command.Subcommands.Add(ImageGenerationGetGeneratedImageCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationOpenaiImagesEditsCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationOpenaiImagesGenerationsCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationOpenaiImagesVariationsCommandApiCommand.Create());
        return command;
    }
}