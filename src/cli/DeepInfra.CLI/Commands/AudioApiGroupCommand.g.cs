#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static partial class AudioApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"audio", @"Audio endpoint commands.");
                         command.Subcommands.Add(AudioOpenaiAudioSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(AudioOpenaiAudioTranscriptionsCommandApiCommand.Create());
                         command.Subcommands.Add(AudioOpenaiAudioTranslationsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}