#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class VideosApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"videos", @"Videos endpoint commands.");
                         command.Subcommands.Add(VideosCreateVideoGenerationCommandApiCommand.Create());
                         command.Subcommands.Add(VideosCreateVideoGeneration2CommandApiCommand.Create());
                         command.Subcommands.Add(VideosGetVideoContentCommandApiCommand.Create());
                         command.Subcommands.Add(VideosGetVideoContent2CommandApiCommand.Create());
                         command.Subcommands.Add(VideosGetVideoGenerationCommandApiCommand.Create());
                         command.Subcommands.Add(VideosGetVideoGeneration2CommandApiCommand.Create());
        return command;
    }
}