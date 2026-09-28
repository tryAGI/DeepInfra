#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class ImageGenerationApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"image-generation", @"Image Generation endpoint commands.");
                         command.Subcommands.Add(ImageGenerationGetGeneratedImageCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationOpenaiImagesEditsCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationOpenaiImagesGenerationsCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationOpenaiImagesVariationsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}