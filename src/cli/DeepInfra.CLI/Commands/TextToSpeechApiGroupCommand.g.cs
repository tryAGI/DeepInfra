#nullable enable

using System.CommandLine;

namespace DeepInfra.CLI.Commands;

internal static class TextToSpeechApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"text-to-speech", @"Text to Speech endpoint commands.");
                         command.Subcommands.Add(TextToSpeechCreateVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechDeleteVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechGetVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechGetVoicesCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechTextToSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechTextToSpeechStreamCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechUpdateVoiceCommandApiCommand.Create());
        return command;
    }
}