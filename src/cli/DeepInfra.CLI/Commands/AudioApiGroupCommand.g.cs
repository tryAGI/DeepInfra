#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class AudioApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"audio", @"Audio endpoint commands.");
                         command.Subcommands.Add(AudioOpenaiAudioSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(AudioOpenaiAudioTranscriptionsCommandApiCommand.Create());
                         command.Subcommands.Add(AudioOpenaiAudioTranslationsCommandApiCommand.Create());
        return command;
    }
}